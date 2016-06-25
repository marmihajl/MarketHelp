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
    public partial class Upravljanje_korisnicima : Form
    {
        public Upravljanje_korisnicima()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dodavanje_korisnika novi_korisnik = new Dodavanje_korisnika();
            novi_korisnik.ShowDialog();
            prikazKorisnika();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upravljanje_korisnicima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16054_DBDataSet.Uloge_korisnika' table. You can move, or remove it, as needed.
            this.uloge_korisnikaTableAdapter.Fill(this._16054_DBDataSet.Uloge_korisnika);
            prikazKorisnika();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnici oznacen = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnici;
            PrijavaKorisnika korisnik = new PrijavaKorisnika();
            korisnik.brisanjeKorisnika(oznacen);
            prikazKorisnika();
        }

        private void prikazKorisnika()
        {
            BindingList<Korisnici> k = null;
            using (var db = new BazaProjekta2())
            {
                k = new BindingList<Korisnici>(db.Korisnici.ToList());
            }
            dgvKorisnici.DataSource = k;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Korisnici oznacen = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnici;
            Dodavanje_korisnika novi_korisnik = new Dodavanje_korisnika(oznacen);
            novi_korisnik.ShowDialog();
            prikazKorisnika();
        }
    }
}
