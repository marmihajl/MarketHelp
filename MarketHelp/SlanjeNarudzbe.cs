using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace MarketHelp
{
    public partial class SlanjeNarudzbe : Form
    {
        bool postoji = false;
        bool izlaz = false;
        Dokumenti d = null;
        Dokumenti dokument;
        BindingSource stavke = new BindingSource();
        string korisnik = "";
        public SlanjeNarudzbe(string k)
        {
            InitializeComponent();
            korisnik = k;
        }
        public SlanjeNarudzbe(Dokumenti d)
        {
            InitializeComponent();
            dokument = d;
        }
      
        

        private void SlanjeNarudzbe_Load(object sender, EventArgs e)
        {
            this.artikliTableAdapter.Fill(this._16054_DBDataSet.Artikli);
            if (dokument == null)
            {
                BindingList<Suradnici> dobavljaci = null;
                using (var db = new BazaProjekta2())
                {
                    dobavljaci = new BindingList<Suradnici>(db.Suradnici.ToList());
                }
                cbDobavljac.DataSource = dobavljaci;
                cbDobavljac.DisplayMember = "naziv";
                Suradnici odabrani = cbDobavljac.SelectedItem as Suradnici;
                cbDobavljac.SelectedIndex = -1;
                cbArtikl.DataSource = null;
                button2.Visible = false;
            }
            else if(dokument != null)
            {
                BindingList<Suradnici> dobavljaci = null;
                using (var db = new BazaProjekta2())
                {
                    dobavljaci = new BindingList<Suradnici>(db.Suradnici.ToList());
                }
                cbDobavljac.DataSource = dobavljaci;
                cbDobavljac.DisplayMember = "naziv";
                cbDobavljac.SelectedItem = dokument.suradnik;
                cbArtikl.Visible = false;
                txtKolicina.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                BindingList<Stavke_dokumenta> sd = null;
                using (var db = new BazaProjekta2())
                {
                    sd = new BindingList<Stavke_dokumenta>(db.Stavke_dokumenta.SqlQuery("select * from Stavke_dokumenta where id_dokumenta=" + dokument.id_dokumenta).ToList());
                }
                dgvStavke.DataSource = sd;
                button1.Visible = false;
            }
        }

        private BindingList<Artikli> odabraniArtikl(Suradnici o)
        {
            BindingList<Artikli> artikli = new BindingList<Artikli>();
            BindingList<Dobavljaci_artikala> listaDobavljaca = null;
            using (var db = new BazaProjekta2())
            {
                listaDobavljaca = new BindingList<Dobavljaci_artikala>(db.Dobavljaci_artikala.Where(x => x.oib == o.oib).ToList());
                foreach (Dobavljaci_artikala item in listaDobavljaca)
                {
                    if(DateTime.Compare(item.datum_zavrsetka.Value, DateTime.Now) >= 0)
                    {
                        artikli.Add(db.Artikli.Where(x => x.id_artikla == item.id_artikla).FirstOrDefault());
                    }
                }
            }
            return artikli;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Artikli odabraniArtikl = cbArtikl.SelectedItem as Artikli;
            Suradnici s = cbDobavljac.SelectedItem as Suradnici;
            string suradnik = null;
            if (s != null)
            {
                suradnik = s.oib;
            }
            else
            {
                MessageBox.Show("Dobavljač mora biti odabran!");
                return;
            }
            
            if(txtKolicina.Text == "")
            {
                MessageBox.Show("Niste unjeli količinu koju želite naručiti!");
                return;
            }
            if(cbArtikl.SelectedValue == null)
            {
                MessageBox.Show("Niste odabrali artikl!");
                return;
            }
            using (var db = new BazaProjekta2())
            {
                if (!postoji)
                {
                    d = new Dokumenti
                    {
                        korisnicko_ime = korisnik,
                        datum = DateTime.Now.Date,
                        nacin_placanja = 1,
                        suradnik = suradnik,
                        napomena = "narudžbenica"
                    };
                    db.Dokumenti.Add(d);
                    db.SaveChanges();
                    postoji = true;
                }


                Dokumenti d2 = db.Dokumenti.Attach(d);
                Stavke_dokumenta sd = new Stavke_dokumenta
                {
                    id_dokumenta = d2.id_dokumenta,
                    id_artikla = odabraniArtikl.id_artikla,
                    kolicina = int.Parse(txtKolicina.Text)
                };
                db.Stavke_dokumenta.Add(sd);
                db.SaveChanges();
                prikazStavaka(d.id_dokumenta);
            }
        }
        
        private void prikazStavaka(int d)
        {
            BindingList<Stavke_dokumenta> stavke = null;
            using (var db = new BazaProjekta2())
            {
                stavke = new BindingList<Stavke_dokumenta>(db.Stavke_dokumenta.Where(x => x.id_dokumenta == d).ToList());
            }
            dgvStavke.DataSource = stavke;
        }
        private void odbacivanjeDokumenta()
        {
            if (d != null)
            {
                Dokumenti odabrani = d;
                using (var db = new BazaProjekta2())
                {
                    db.Stavke_dokumenta.SqlQuery("delete from Stavke_dokumenta where id_dokumenta = " + odabrani.id_dokumenta);
                    db.Dokumenti.Attach(odabrani);
                    db.Dokumenti.Remove(odabrani);
                    db.SaveChanges();

                }
            }
        }

        private void SlanjeNarudzbe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!izlaz)
            {
                odbacivanjeDokumenta();
            }
            GC.Collect();
        }

        private void cbDobavljac_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbDobavljac_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbDobavljac.SelectedIndex != -1)
            {
                Suradnici odabrani = cbDobavljac.SelectedItem as Suradnici;
                cbArtikl.DataSource = odabraniArtikl(odabrani);
                cbArtikl.DisplayMember = "naziv";
                cbArtikl.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            export();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            izlaz = true;
            GC.Collect();
            this.Close();
        }
        private void export()
        {
            string putanja = "C:\\Users\\marin\\Desktop\\r16054\\PDF\\";
            Suradnici suradnik = null;
            using (var db = new BazaProjekta2())
            {
                suradnik = db.Suradnici.Where(x => x.oib == dokument.suradnik).FirstOrDefault();
            }
            FileStream stream = new FileStream(putanja + "Narudzbenica_br" + dokument.id_dokumenta, FileMode.Create);
            Document doc = new Document(PageSize.A4, 2f, 2f, 2f, 0f);
            PdfWriter.GetInstance(doc, stream);
            doc.Open();
            string zaglavlje = "Pošiljatelj: Tvrtka d.o.o." + Environment.NewLine + "Datum: " + DateTime.Today.Date + Environment.NewLine + "Primatelj:" + suradnik.naziv + Environment.NewLine + "Adresa:" + suradnik.adresa + Environment.NewLine + "Kontakt:" + suradnik.kontakt + Environment.NewLine + Environment.NewLine;
            doc.Add(new Paragraph(zaglavlje));
            PdfPTable table = new PdfPTable(2);
            table.AddCell("Artikl");
            table.AddCell("Kolicina");

            for (int i = 0; i < dgvStavke.RowCount; i++)
            {
                Artikli a = null;
                using (var db = new BazaProjekta2())
                {
                    int artiklID = int.Parse(dgvStavke.Rows[i].Cells[1].Value.ToString());
                    a = db.Artikli.Where(x => x.id_artikla == artiklID).FirstOrDefault();
                    table.AddCell(a.naziv.ToString());
                    table.AddCell(dgvStavke.Rows[i].Cells[2].Value.ToString());
                }
            }
            doc.Add(table);
            doc.Close();
            stream.Close();
            MessageBox.Show("Narudžbenica je exportirana na mjestu: " + putanja + "Narudzbenica_br" + dokument.id_dokumenta);
        }
    }
}
