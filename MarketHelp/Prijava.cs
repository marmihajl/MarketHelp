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
    public partial class Prijava : Form
    {
        string vrijeme_prijave;
        public Prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrijavaKorisnika korisnik = new PrijavaKorisnika();
            if(korisnik.postojiKorisnik(txtKorisnik.Text) == false)
            {
                return;
            }
            if (korisnik.korisnikovaLozinka(txtLozinka.Text) == false)
            {
                return;
            }
            vrijeme_prijave = DateTime.Now.ToShortTimeString();
            if (korisnik.korisnikVoditelj(txtKorisnik.Text) == true)
            {
                Izbornik izbornik = new Izbornik(vrijeme_prijave, txtKorisnik.Text);
                izbornik.WindowState = FormWindowState.Maximized;
                izbornik.Show();
                this.Hide();
            }
            else
            {
                Izbornik_prodavac izbornik = new Izbornik_prodavac(vrijeme_prijave, txtKorisnik.Text);
                izbornik.WindowState = FormWindowState.Maximized;
                izbornik.Show();
                this.Hide();
            }
        }
    }
}
