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
    public partial class ParametriZaliha : Form
    {
        public ParametriZaliha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMin.Text == "")
            {
                MessageBox.Show("Niste unjeli minimalnu količinu za artikl");
                return;
            }
            if(txtMax.Text == "")
            {
                MessageBox.Show("Niste unjeli maksimalnu količinu za artikl");
                return;
            }
            Artikli odabraniArtikl = cbArtikli.SelectedItem as Artikli;
            using (var db = new BazaProjekta2())
            {
                db.Artikli.Attach(odabraniArtikl);
                odabraniArtikl.min_kolicina = int.Parse(txtMin.Text);
                odabraniArtikl.max_kolicina = int.Parse(txtMax.Text);
                db.SaveChanges();
            }
            GC.Collect();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void ParametriZaliha_Load(object sender, EventArgs e)
        {
            BindingList<Artikli> artikli = null;
            using (var db = new BazaProjekta2())
            {
                artikli = new BindingList<Artikli>(db.Artikli.ToList());
            }
            cbArtikli.DataSource = artikli;
            cbArtikli.DisplayMember = "naziv";
        }
    }
}
