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
    public partial class Pregled_placa : Form
    {
        public Pregled_placa()
        {
            InitializeComponent();
        }

        private void Pregled_plaća_Load(object sender, EventArgs e)
        {
            BindingList<Place> place = null;
            using (var db = new BazaProjekta2())
            {
                place = new BindingList<Place>(db.Place.ToList());
            }
            dgvPlace.DataSource = place;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
