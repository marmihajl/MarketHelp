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
    public partial class Pregled_i_storniranje_izdanih_racuna : Form
    {
        public Pregled_i_storniranje_izdanih_racuna()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pregled_i_storniranje_izdanih_racuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16054_DBDataSet.Suradnici' table. You can move, or remove it, as needed.
            this.suradniciTableAdapter.Fill(this._16054_DBDataSet.Suradnici);
            // TODO: This line of code loads data into the '_16054_DBDataSet.Nacini_placanja' table. You can move, or remove it, as needed.
            this.nacini_placanjaTableAdapter.Fill(this._16054_DBDataSet.Nacini_placanja);
            prikazRacuna();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dokumenti odabrani = dgvRacuni.SelectedRows[0].DataBoundItem as Dokumenti;
            using (var db = new BazaProjekta2())
            {
                db.Stavke_dokumenta.Where(x => x.id_dokumenta == odabrani.id_dokumenta).ToList().ForEach(x => db.Stavke_dokumenta.Remove(x));
                db.Dokumenti.Attach(odabrani);
                db.Dokumenti.Remove(odabrani);
                db.SaveChanges();
            }
            prikazRacuna();
        }

        private void prikazRacuna()
        {
            BindingList<Dokumenti> racuni = null;
            using (var db = new BazaProjekta2())
            {
                racuni = new BindingList<Dokumenti>(db.Dokumenti.Where(x => x.napomena == "račun").ToList());
            }
            dgvRacuni.DataSource = racuni;
        }

        private void dgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvRacuni_MouseUp(object sender, MouseEventArgs e)
        {
            Dokumenti d = null;
            using (var db = new BazaProjekta2())
            {
                d = db.Dokumenti.Find(dgvRacuni.SelectedRows[0].Cells[0].Value);
            }
            Izdavanje_racuna racun = new Izdavanje_racuna(d);
            racun.ShowDialog();
        }
    }
}
