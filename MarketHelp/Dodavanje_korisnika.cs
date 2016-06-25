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
    public partial class Dodavanje_korisnika : Form
    {
        Korisnici odabraniKorisnik = null;
        public Dodavanje_korisnika()
        {
            InitializeComponent();
        }
        public Dodavanje_korisnika(Korisnici o)
        {
            InitializeComponent();
            odabraniKorisnik = o;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if(Controls[i].GetType() == typeof(TextBox))
                {
                    if(Controls[i].Text == "")
                    {
                        MessageBox.Show("Svi podatci o korisniku moraju biti uneseni!");
                        return;
                    }
                }
            }
            PrijavaKorisnika korisnik = new PrijavaKorisnika();
            Uloge_korisnika uloga = cbUloga.SelectedValue as Uloge_korisnika;
            int tipUloge = uloga.id_uloge;
            if(odabraniKorisnik == null)
            {
                try
                {
                    korisnik.dodavanjeKorisnika(txtIme.Text, txtKontakt.Text, txtKorisnickoIme.Text, txtLozinka.Text, tipUloge, int.Parse(txtSatnica.Text), int.Parse(txtPrekovremeno.Text));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Satnica ili prekovemeni sati je uneseno u krivom formatu");
                }
            }
            else if (odabraniKorisnik != null)
            {
                try
                {
                    korisnik.uredivanjeKorisnika(odabraniKorisnik, txtIme.Text, txtKontakt.Text, txtKorisnickoIme.Text, txtLozinka.Text, tipUloge, int.Parse(txtSatnica.Text), int.Parse(txtPrekovremeno.Text));
                }
                catch(FormatException)
                {
                    MessageBox.Show("Satnica ili prekovemeni sati je uneseno u krivom formatu");
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodavanje_korisnika_Load(object sender, EventArgs e)
        {
            BindingList<Uloge_korisnika> tipoviKorisnika = null;
            using (var db = new BazaProjekta2())
            {

                tipoviKorisnika = new BindingList<Uloge_korisnika>(db.Uloge_korisnika.ToList());
            }
            cbUloga.DataSource = tipoviKorisnika;
            cbUloga.DisplayMember = "naziv";
            if(odabraniKorisnik != null)
            {
                txtIme.Text = odabraniKorisnik.ime_prezime;
                txtKontakt.Text = odabraniKorisnik.kontakt;
                txtKorisnickoIme.Text = odabraniKorisnik.korisnicko_ime;
                txtKorisnickoIme.Enabled = false;
                txtLozinka.Text = odabraniKorisnik.lozinka;
                txtSatnica.Text = odabraniKorisnik.satnica.ToString();
                txtPrekovremeno.Text = odabraniKorisnik.satnica_prekovremeno.ToString();
                foreach (var item in tipoviKorisnika)
                {
                    if(item.id_uloge == odabraniKorisnik.id_uloge)
                    {
                        cbUloga.SelectedItem = item;
                    }
                }
            }
        }

        
    }
}
