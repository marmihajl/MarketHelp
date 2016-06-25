using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MarketHelp
{
    class PrijavaKorisnika
    {
        string korisnicko_ime { get; set; }
        public bool postojiKorisnik(string ime)
        {
            int postoji = 0;
            using (var db = new BazaProjekta2())
            {
                postoji = db.Korisnici.Count(korisnik => korisnik.korisnicko_ime == ime);
                if(postoji == 0)
                {
                    MessageBox.Show("Uneseni korisnik ne postoji u bazi!");
                    return false;
                }
            }
            korisnicko_ime = ime;
            return true;
        }
        public bool korisnikovaLozinka(string lozinka)
        {
            int postoji = 0;
            using (var db = new BazaProjekta2())
            {
                var rezultat = db.Korisnici.Where(korisnik => korisnik.korisnicko_ime == korisnicko_ime && korisnik.lozinka == lozinka).ToList();
                postoji = db.Korisnici.Count(korisnik => korisnik.lozinka == lozinka);
                if (postoji == 0)
                {
                    MessageBox.Show("Unešena je pogrešna lozinka!");
                    return false;
                }
            }
            return true;
        }
        public void dodavanjeKorisnika(string imePrezime, string kontakt, string korisnickoIme, string lozinka, int uloga, int sat, int prekovremeno)
        {
            using (var db = new BazaProjekta2())
            {
                Korisnici korisnik = new Korisnici
                {
                    ime_prezime = imePrezime,
                    kontakt = kontakt,
                    korisnicko_ime = korisnickoIme,
                    lozinka = lozinka,
                    id_uloge = uloga,
                    satnica = sat,
                    satnica_prekovremeno = prekovremeno
                };
                db.Korisnici.Add(korisnik);
                db.SaveChanges();
            }
        }

        public void uredivanjeKorisnika(Korisnici k, string imePrezime, string kontakt, string korisnickoIme, string lozinka, int uloga, int sat, int prekovremeno)
        {
            
            using (var db = new BazaProjekta2())
            {
                db.Korisnici.Attach(k);
                k.ime_prezime = imePrezime;
                k.kontakt = kontakt;
                k.korisnicko_ime = korisnickoIme;
                k.lozinka = lozinka;
                k.id_uloge = uloga;
                k.satnica = sat;
                k.satnica_prekovremeno = prekovremeno;
                db.SaveChanges();
            }
        }

        public void brisanjeKorisnika(Korisnici k)
        {
            using (var db = new BazaProjekta2())
            {
                db.Korisnici.Attach(k);
                if(k.Dokumenti.Count == 0 && k.Place.Count == 0)
                {
                    db.Korisnici.Remove(k);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nije moguće obrisati odabranog korisnika");
                }
            }
        }

        public bool korisnikVoditelj(string k)
        {
            int postoji = 0;
            using (var db = new BazaProjekta2())
            {
                postoji = db.Korisnici.Count(korisnik => korisnik.korisnicko_ime == k && korisnik.id_uloge == 1);
                if(postoji == 1)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
