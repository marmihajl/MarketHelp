using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketHelp
{
    public partial class Izdavanje_racuna : Form
    {
        bool postoji = false;
        bool izdavanje = false;
        Dokumenti d = null;
        Dokumenti d2 = null;
        string korisnik = "";
        int brojDokumenta;
        public Izdavanje_racuna(string x)
        {
            InitializeComponent();
            korisnik = x;
        }
        public Izdavanje_racuna(Dokumenti d)
        {
            InitializeComponent();
            d2 = d;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvStavke.RowCount == 0)
            {
                MessageBox.Show("Nije moguće izdati račun bez stavaka!");
                return;
            }
            BindingList<Stavke_dokumenta> stavke = null;
            using (var db = new BazaProjekta2())
            {
                stavke = new BindingList<Stavke_dokumenta>(db.Stavke_dokumenta.Where(x => x.id_dokumenta == d.id_dokumenta).ToList());
            }
            for (int i = 0; i < stavke.Count; i++)
            {
                using (var db = new BazaProjekta2())
                {
                    Artikli a = db.Artikli.Find(stavke[i].id_artikla);
                    db.Artikli.Attach(a);
                    a.kolicina -= stavke[i].kolicina;
                    db.SaveChanges();
                    db.Dokumenti.Attach(d);
                    d.iznos_racuna = Math.Round(float.Parse(txtUkupno.Text),2);
                    if(txtPopust.Text != "")
                    {
                        d.popust = Math.Round(float.Parse(txtPopust.Text) / (float)100,2);
                    }
                    else
                    {
                        d.popust = 0;
                    }
                    
                    db.SaveChanges();
                }
            }
            izdavanje = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pregled_i_storniranje_izdanih_racuna novi_racun = new Pregled_i_storniranje_izdanih_racuna();
            novi_racun.Show();
        }

        private void Izdavanje_racuna_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Izdavanje_racuna_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16054_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16054_DBDataSet.Artikli);
            txtUkupno.Enabled = false;
            BindingList<Suradnici> suradnici = null;
            using (var db = new BazaProjekta2())
            {

                suradnici = new BindingList<Suradnici>(db.Suradnici.ToList());
            }
            cbKupac.DataSource = suradnici;
            cbKupac.DisplayMember = "naziv";
            cbKupac.SelectedIndex = -1;

            BindingList<Artikli> artikli = null;
            using (var db = new BazaProjekta2())
            {

                artikli = new BindingList<Artikli>(db.Artikli.ToList());
            }
            cbArtikl.DataSource = artikli;
            cbArtikl.DisplayMember = "naziv";
            cbArtikl.SelectedIndex = -1;

            BindingList<Nacini_placanja> placanje = null;
            using (var db = new BazaProjekta2())
            {

                placanje = new BindingList<Nacini_placanja>(db.Nacini_placanja.ToList());
            }
            cbPlacanje.DataSource = placanje;
            cbPlacanje.DisplayMember = "naziv_placanja";
            

            if (d2 != null)
            {

                Suradnici s = null;
                Nacini_placanja np = null;
                using (var db = new BazaProjekta2())
                {
                    np = db.Nacini_placanja.Find(d2.nacin_placanja);
                    s = db.Suradnici.Find(d2.suradnik);
                }
                cbKupac.SelectedItem = s;
                cbPlacanje.SelectedItem = np;
                cbArtikl.Visible = false;
                txtKolicina.Visible = false;
                dodaj.Visible = false;
                int p = 0;
                if (d2.popust != null)
                {
                    p = (int)(d2.popust * 100);
                }
                txtPopust.Text = p.ToString();
                txtUkupno.Text = d2.iznos_racuna.ToString();
                BindingList<Stavke_dokumenta> sd = null; 
                using (var db = new BazaProjekta2())
                {
                    sd = new BindingList<Stavke_dokumenta>(db.Stavke_dokumenta.Where(x => x.id_dokumenta == d2.id_dokumenta).ToList());
                }
                dgvStavke.DataSource = sd;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    this.Controls[i].Enabled = false;
                }
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if(cbArtikl.SelectedValue == null)
            {
                MessageBox.Show("Niste odabrali artikl");
                return;
            }
            if(txtKolicina.Text == "")
            {
                MessageBox.Show("Niste unjeli količinu artikla!");
                return;
            }
            btnPregledIStorniranje.Enabled = false;
            Artikli odabraniArtikl = cbArtikl.SelectedItem as Artikli;
            Nacini_placanja np = cbPlacanje.SelectedItem as Nacini_placanja;
            Suradnici s = cbKupac.SelectedItem as Suradnici;
            int placanje = np.id_nacina_placanja;
            string suradnik = null;
            if(s != null)
            {
                suradnik = s.oib;
            }
            try
            {
                if (odabraniArtikl.kolicina <= int.Parse(txtKolicina.Text))
                {
                    MessageBox.Show("Nema dovoljne količine odabranog artikla na skladišti");
                }
                else

                {

                    using (var db = new BazaProjekta2())
                    {
                        if (!postoji)
                        {
                            d = new Dokumenti
                            {
                                korisnicko_ime = korisnik,
                                datum = DateTime.Now.Date,
                                nacin_placanja = placanje,
                                suradnik = suradnik,
                                napomena = "račun"
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
                        ukupno(d.id_dokumenta);
                    }

                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Unesena vrijednost nije broj!");
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

        private void ukupno(int d)
        {
            brojDokumenta = d;
            float zbroj = 0;
            BindingList<Stavke_dokumenta> stavke = null;
            using (var db = new BazaProjekta2())
            {
                stavke = new BindingList<Stavke_dokumenta>(db.Stavke_dokumenta.Where(x => x.id_dokumenta == d).ToList());
            }
            for (int i = 0; i < stavke.Count; i++)
            {
                using (var db = new BazaProjekta2())
                {
                    Artikli a = db.Artikli.Find(stavke[i].id_artikla);
                    zbroj += (float)a.cijena * stavke[i].kolicina;
                }
            }
            try
            {
                if (txtPopust.Text != "")
                {
                    int p = int.Parse(txtPopust.Text);
                    zbroj = zbroj - ((float)zbroj * (float)p / (float)100);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Popust je unesen u krivom formatu: NIJE BROJ!");
            }
            txtUkupno.Text = zbroj.ToString();
        }

        private void txtPopust_TextChanged(object sender, EventArgs e)
        {
            if (postoji)
            {
                ukupno(d.id_dokumenta);
            }
            
        }

        private void Izdavanje_racuna_Leave(object sender, EventArgs e)
        {

        }

        private void Izdavanje_racuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (izdavanje == false)
            {
                odbacivanjeDokumenta();
            }
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
    }
}
