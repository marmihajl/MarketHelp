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
    public partial class NoviSuradnik : Form
    {
        public Suradnici odabraniSuradnik = null;
        public NoviSuradnik()
        {
            InitializeComponent();
        }
        public NoviSuradnik(Suradnici s)
        {
            InitializeComponent();
            odabraniSuradnik = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if(Controls[i].GetType() == typeof(TextBox))
                {
                    if(Controls[i].Text == "" && Controls[i].Name != "txtNapomena")
                    {
                        MessageBox.Show("Sva polja osim polja za napomenu moraju biti unesena");
                        return;
                    }
                }
            }
            using (var db = new BazaProjekta2())
            {
                if(odabraniSuradnik == null)
                {
                    int provjeraOIB = db.Suradnici.Count(x => x.oib == txtOIB.Text);
                    if(provjeraOIB > 0)
                    {
                        MessageBox.Show("Suradnik s unesenim OIB-om već postoji u bazi podataka!");
                        return;
                    }
                    Suradnici suradnik = new Suradnici
                    {
                        oib = txtOIB.Text,
                        naziv = txtNaziv.Text,
                        adresa = txtAdresa.Text,
                        kontakt = txtKontakt.Text,
                        napomena = txtNapomena.Text
                    };
                    db.Suradnici.Add(suradnik);
                    db.SaveChanges();
                }
                else
                {
                    db.Suradnici.Attach(odabraniSuradnik);
                    odabraniSuradnik.oib = txtOIB.Text;
                    odabraniSuradnik.naziv = txtNaziv.Text;
                    odabraniSuradnik.adresa = txtAdresa.Text;
                    odabraniSuradnik.kontakt = txtKontakt.Text;
                    odabraniSuradnik.napomena = txtNapomena.Text;
                    db.SaveChanges();
                }
            }
            GC.Collect();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void NoviSuradnik_Load(object sender, EventArgs e)
        {
            if (odabraniSuradnik != null)
            {
                txtOIB.Text = odabraniSuradnik.oib;
                txtOIB.Enabled = false;
                txtNaziv.Text = odabraniSuradnik.naziv;
                txtAdresa.Text = odabraniSuradnik.adresa;
                txtKontakt.Text = odabraniSuradnik.kontakt;
                txtNapomena.Text = odabraniSuradnik.napomena;
            }
        }
    }
}
