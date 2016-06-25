using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UputePDF;
namespace MarketHelp
{
    public partial class Izbornik_prodavac : Form
    {
        string prijava, korisnik;
        public Izbornik_prodavac(string x, string k)
        {
            InitializeComponent();
            prijava = x;
            korisnik = k;
        }

        private void računiToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            Izdavanje_racuna racun = new Izdavanje_racuna(korisnik);
            racun.MdiParent = this;
            racun.WindowState = FormWindowState.Maximized;
            
            racun.Show();
        }

        private void narudžbeToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            UpravljanjeNarudzbama narudzba = new UpravljanjeNarudzbama(korisnik);
            narudzba.MdiParent = this;
            narudzba.WindowState = FormWindowState.Maximized;
            narudzba.Show();
        }

        private void korisniciToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            Upravljanje_korisnicima korisnici = new Upravljanje_korisnicima();
            korisnici.MdiParent = this;
            korisnici.WindowState = FormWindowState.Maximized;
            korisnici.Show();
        }

        private void dobavljačiToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            UpravljanjeDobavljacima dobavljaci = new UpravljanjeDobavljacima();
            dobavljaci.MdiParent = this;
            dobavljaci.WindowState = FormWindowState.Maximized;
            dobavljaci.Show();
        }

        private void rokTrajanjaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            Pregled_roka_trajanja trajanje = new Pregled_roka_trajanja();
            trajanje.MdiParent = this;
            trajanje.WindowState = FormWindowState.Maximized;
            trajanje.Show();
        }

        private void plaćeToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            Pregled_placa place = new Pregled_placa();
            place.MdiParent = this;
            place.WindowState = FormWindowState.Maximized;
            place.Show();
        }

        private void Izbornik_prodavac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Upute u = new Upute();
                u.OtvoriUpute();
            }
        }

        private void uputeF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Upute u = new Upute();
            u.OtvoriUpute();
        }

        private void odjavaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            DateTime vrijemePrijave = DateTime.Parse(prijava);
            string odjava = DateTime.Now.ToShortTimeString();
            DateTime vrijemeOdjave = DateTime.Parse(odjava);
            int sati = (vrijemeOdjave - vrijemePrijave).Minutes;
            using (var db = new BazaProjekta2())
            {
                int normalno = 0, prekovremeno = 0;
                if (sati > 8 * 60)
                {
                    normalno = 8 * 60;
                    prekovremeno = sati - (8 * 60);
                    int provjera = db.Place.Count(x => x.korisnicko_ime == korisnik && x.mjesec == DateTime.Now.Month);
                    Korisnici k = db.Korisnici.Where(x => x.korisnicko_ime == korisnik).FirstOrDefault();
                    if (provjera == 0)
                    {
                        Place placa = new Place
                        {
                            korisnicko_ime = korisnik,
                            odradeno_sati = normalno,
                            odradeno_prekovremeno = prekovremeno,
                            mjesec = DateTime.Now.Month,
                            iznos_place = Math.Round((float)k.satnica * (float)normalno / 60 + (float)k.satnica_prekovremeno * (float)prekovremeno / 60, 2)
                        };
                        db.Place.Add(placa);
                        db.SaveChanges();
                    }
                    else
                    {
                        Place p = db.Place.Where(x => x.korisnicko_ime == korisnik && x.mjesec == DateTime.Now.Month).FirstOrDefault();
                        db.Place.Attach(p);
                        p.odradeno_sati += normalno;
                        p.odradeno_prekovremeno += prekovremeno;
                        p.iznos_place += Math.Round((float)k.satnica * (float)normalno / 60 + (float)k.satnica_prekovremeno * (float)prekovremeno / 60, 2);

                        db.SaveChanges();
                    }
                }
                else
                {
                    normalno = sati;
                    int provjera = db.Place.Count(x => x.korisnicko_ime == korisnik && x.mjesec == DateTime.Now.Month);
                    Korisnici k = db.Korisnici.Where(x => x.korisnicko_ime == korisnik).FirstOrDefault();
                    if (provjera == 0)
                    {
                        Place placa = new Place
                        {
                            korisnicko_ime = korisnik,
                            odradeno_sati = normalno,
                            mjesec = DateTime.Now.Month,
                            iznos_place = Math.Round((float)k.satnica * (float)normalno / 60 + (float)k.satnica_prekovremeno * (float)prekovremeno / 60, 2)
                        };
                        db.Place.Add(placa);
                        db.SaveChanges();
                    }
                    else
                    {
                        Place p = db.Place.Where(x => x.korisnicko_ime == korisnik && x.mjesec == DateTime.Now.Month).FirstOrDefault();
                        db.Place.Attach(p);
                        p.odradeno_sati += normalno;
                        p.iznos_place += Math.Round((float)k.satnica * (float)normalno / 60, 2);
                        db.SaveChanges();
                    }
                }

            }
            GC.Collect();
            Application.Exit();
        }
    }
}
