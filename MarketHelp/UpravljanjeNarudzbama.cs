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
    public partial class UpravljanjeNarudzbama : Form
    {
        string korisnik = "";
        public UpravljanjeNarudzbama(string k)
        {
            InitializeComponent();
            korisnik = k;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNarudzbe.RowCount; i++)
            {
                if(dgvNarudzbe.Rows[i].Cells["zaprimljeno"].Value != null)
                {
                    int idDokument = (int)dgvNarudzbe.Rows[i].Cells[0].Value;
                    List<Stavke_dokumenta> stavkeDokumenta = null;
                    Artikli artikl = null;
                    using (var db = new BazaProjekta2())
                    {
                        stavkeDokumenta = new List<Stavke_dokumenta>(db.Stavke_dokumenta.Where(x => x.id_dokumenta == idDokument).ToList());
                        foreach (Stavke_dokumenta item in stavkeDokumenta)
                        {
                            int provjera = db.Artikli.Count(x => x.id_artikla == item.id_artikla && x.kolicina == 0);
                            if(provjera > 0)
                            {
                                artikl = db.Artikli.Where(x => x.id_artikla == item.id_artikla).FirstOrDefault();
                                
                                db.Artikli.Attach(artikl);
                                artikl.kolicina += item.kolicina;
                                db.SaveChanges();
                                Dokumenti dokument = db.Dokumenti.Where(x => x.id_dokumenta == idDokument).FirstOrDefault();
                                db.Dokumenti.Attach(dokument);
                                dokument.realiziran = 1;
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Određenog artikla iz narudžbenice još ima na skladištu. Preporuča se da se po narudžbi naručuje jedna proizvod!");

                            }
                        }
                    }
                    if(artikl != null)
                    {
                        DodajRok forma = new DodajRok(artikl);
                        forma.ShowDialog();
                    }
                    
                    
                }
            }
            GC.Collect();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlanjeNarudzbe nova_narudzba = new SlanjeNarudzbe(korisnik);
            nova_narudzba.ShowDialog();
            prikazNarudzbi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zalihe zalihe = new Zalihe();
            zalihe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParametriZaliha parametri = new ParametriZaliha();
            parametri.ShowDialog();
        }

        private void UpravljanjeNarudzbama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16054_DBDataSet.Suradnici' table. You can move, or remove it, as needed.
            this.suradniciTableAdapter.Fill(this._16054_DBDataSet.Suradnici);
            // TODO: This line of code loads data into the '_16054_DBDataSet.Nacini_placanja' table. You can move, or remove it, as needed.
            this.nacini_placanjaTableAdapter.Fill(this._16054_DBDataSet.Nacini_placanja);
            prikazNarudzbi();
        }
        private void prikazNarudzbi()
        {
            BindingList<Dokumenti> dok = null;
            using (var db = new BazaProjekta2())
            {
                dok = new BindingList<Dokumenti>(db.Dokumenti.Where(x => x.napomena == "narudžbenica").ToList());
            }
            dgvNarudzbe.DataSource = dok;
        }

        private void toolStripMenuItem1_MouseUp(object sender, MouseEventArgs e)
        {
            Dokumenti odabraniDokument = dgvNarudzbe.SelectedRows[0].DataBoundItem as Dokumenti;
            SlanjeNarudzbe forma = new SlanjeNarudzbe(odabraniDokument);
            forma.ShowDialog();
        }

        private void toolStripMenuItem2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
