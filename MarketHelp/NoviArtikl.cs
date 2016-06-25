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
    public partial class NoviArtikl : Form
    {
        Artikli odabraniArtikl = null;
        public NoviArtikl()
        {
            InitializeComponent();
        }

        public NoviArtikl(Artikli a)
        {
            InitializeComponent();
            odabraniArtikl = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i].GetType() == typeof(TextBox))
                {
                    if (Controls[i].Text == "")
                    {
                        MessageBox.Show("Sva polja osim datuma se moraju unjesti!");
                        return;
                    }
                }
            }
            try
            {
                using (var db = new BazaProjekta2())
                {
                    if (odabraniArtikl == null)
                    {
                        if (DateTime.Today.ToString("d") == txtRok.Value.ToString("d"))
                        {
                            Artikli artikl = new Artikli
                            {
                                naziv = txtNaziv.Text,
                                kolicina = int.Parse(txtKolicina.Text),
                                cijena = Math.Round(float.Parse(txtCijena.Text), 2)
                            };
                            db.Artikli.Add(artikl);
                            db.SaveChanges();
                        }
                        else
                        {
                            Artikli artikl = new Artikli
                            {
                                naziv = txtNaziv.Text,
                                kolicina = int.Parse(txtKolicina.Text),
                                cijena = Math.Round(float.Parse(txtCijena.Text), 2),
                                rok_trajanja = txtRok.Value
                            };
                            db.Artikli.Add(artikl);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.Artikli.Attach(odabraniArtikl);
                        odabraniArtikl.naziv = txtNaziv.Text;
                        odabraniArtikl.cijena = float.Parse(txtCijena.Text);
                        odabraniArtikl.kolicina = int.Parse(txtKolicina.Text);
                        db.SaveChanges();
                    }
                }
                GC.Collect();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Cijena i/ili količina nisu uneseni u obliku broja!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void NoviArtikl_Load(object sender, EventArgs e)
        {
            if(odabraniArtikl != null)
            {
                txtNaziv.Text = odabraniArtikl.naziv;
                txtCijena.Text = odabraniArtikl.cijena.ToString();
                txtKolicina.Text = odabraniArtikl.kolicina.ToString();
                txtRok.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
