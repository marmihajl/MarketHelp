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
    public partial class Zalihe : Form
    {
        public Zalihe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void Zalihe_Load(object sender, EventArgs e)
        {
            BindingList<Artikli> artikli = null;
            using (var db = new BazaProjekta2())
            {
                artikli = new BindingList<Artikli>(db.Artikli.ToList());
            }
            dgvZalihe.DataSource = artikli;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            
            using (var db = new BazaProjekta2())
            {
                //this.reportViewer1.LocalReport.DataSources.Add(db.Artikli.d);
            }
            
        }
    }
}
