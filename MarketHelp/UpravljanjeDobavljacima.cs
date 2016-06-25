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
    public partial class UpravljanjeDobavljacima : Form
    {
        public UpravljanjeDobavljacima()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoviSuradnik suradni = new NoviSuradnik();
            suradni.ShowDialog();
            prikazDobavljaca();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoviArtikl novi_artikl = new NoviArtikl();
            novi_artikl.ShowDialog();
            prikazArtikala();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DateTime.Compare(datumPocetka.Value,datumZavrsetka.Value) >= 0)
            {
                MessageBox.Show("Datum završetka ugovora mora biti veči od datuma početka ugovora!");
                return;
            }
            using (var db = new BazaProjekta2())
            {
                Dobavljaci_artikala da = new Dobavljaci_artikala
                {
                    oib = (cbDobavljaci.SelectedItem as Suradnici).oib,
                    id_artikla = (cbArtikli.SelectedItem as Artikli).id_artikla,
                    datum_pocetka = datumPocetka.Value,
                    datum_zavrsetka = datumZavrsetka.Value
                };
                db.Dobavljaci_artikala.Add(da);
                db.SaveChanges();
            }
            prikazDobavljacaArtikala();
        }

        private void UpravljanjeDobavljacima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16054_DBDataSet.Suradnici' table. You can move, or remove it, as needed.
            this.suradniciTableAdapter.Fill(this._16054_DBDataSet.Suradnici);
            // TODO: This line of code loads data into the '_16054_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._16054_DBDataSet.Artikli);
            prikazDobavljaca();
            prikazArtikala();
            prikazDobavljacaArtikala();
        }

        private void prikazDobavljaca()
        {
            BindingList<Suradnici> suradnici = null;
            using (var db = new BazaProjekta2())
            {

                suradnici = new BindingList<Suradnici>(db.Suradnici.ToList());
            }
            dgvDobavljaci.DataSource = suradnici;
            cbDobavljaci.DataSource = suradnici;
            cbDobavljaci.DisplayMember = "naziv";
        }
        
        private void prikazArtikala()
        {
            BindingList<Artikli> artikli = null;
            using (var db = new BazaProjekta2())
            {
                artikli = new BindingList<Artikli>(db.Artikli.ToList());
            }
            dgvArtikli.DataSource = artikli;
            cbArtikli.DataSource = artikli;
            cbArtikli.DisplayMember = "naziv";
            
        }

        private void prikazDobavljacaArtikala()
        {
            BindingList<Dobavljaci_artikala> dob = null;
            using (var db = new BazaProjekta2())
            {
                dob = new BindingList<Dobavljaci_artikala>(db.Dobavljaci_artikala.ToList());
            }
            dgvDobavljaciArtikala.DataSource = dob;
        }

        private void uredi_MouseUp(object sender, MouseEventArgs e)
        {
            Suradnici s = dgvDobavljaci.SelectedRows[0].DataBoundItem as Suradnici;
            NoviSuradnik suradni = new NoviSuradnik(s);
            suradni.ShowDialog();
            prikazDobavljaca();
        }

        private void izbrisi_MouseUp(object sender, MouseEventArgs e)
        {
            Suradnici s = dgvDobavljaci.SelectedRows[0].DataBoundItem as Suradnici;
            using (var db = new BazaProjekta2())
            {
                db.Suradnici.Attach(s);
                if(s.Dobavljaci_artikala.Count == 0 && s.Dokumenti.Count == 0)
                {
                    db.Suradnici.Remove(s);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nije moguće izbrisati odabranog suradnika!");
                }
            }
            prikazDobavljaca();
        }

        private void toolStripMenuItem1_MouseUp(object sender, MouseEventArgs e)
        {
            Artikli a = dgvArtikli.SelectedRows[0].DataBoundItem as Artikli;
            NoviArtikl novi_artikl = new NoviArtikl(a);
            novi_artikl.ShowDialog();
            prikazArtikala();
        }

        private void toolStripMenuItem2_MouseUp(object sender, MouseEventArgs e)
        {
            Artikli a = dgvArtikli.SelectedRows[0].DataBoundItem as Artikli;
            using (var db = new BazaProjekta2())
            {
                db.Artikli.Attach(a);
                if(a.Dobavljaci_artikala.Count == 0 && a.Stavke_dokumenta.Count == 0){
                    db.Artikli.Remove(a);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Odabrani artikl se ne može obrisati");
                }
            }
            prikazArtikala();
        }

        private void toolStripMenuItem3_MouseUp(object sender, MouseEventArgs e)
        {
            Dobavljaci_artikala da = dgvDobavljaciArtikala.SelectedRows[0].DataBoundItem as Dobavljaci_artikala;
            cbArtikli.SelectedItem = da.id_artikla;
            cbDobavljaci.SelectedItem = da.oib;
        }

        private void toolStripMenuItem4_MouseUp(object sender, MouseEventArgs e)
        {
            Dobavljaci_artikala da = dgvDobavljaciArtikala.SelectedRows[0].DataBoundItem as Dobavljaci_artikala;
            using (var db = new BazaProjekta2())
            {
                db.Dobavljaci_artikala.Attach(da);
                db.Dobavljaci_artikala.Remove(da);
                db.SaveChanges();
            }
            prikazDobavljacaArtikala();
        }

        private void dgvDobavljaciArtikala_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvDobavljaciArtikala_Click(object sender, EventArgs e)
        {
            string oib = dgvDobavljaciArtikala.SelectedRows[0].Cells[1].ToString();
            cbDobavljaci.SelectedIndex = cbDobavljaci.FindString(oib);
        }
    }
}
