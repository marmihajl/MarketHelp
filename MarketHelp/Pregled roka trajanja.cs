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
    public partial class Pregled_roka_trajanja : Form
    {
        public Pregled_roka_trajanja()
        {
            InitializeComponent();
        }

        private void PotvrdiButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgbRok.RowCount; i++)
            {
                if(dgbRok.Rows[i].Cells["ukloni"].Value != null)
                {
                    Artikli uklonjeni = dgbRok.Rows[i].DataBoundItem as Artikli;
                    using (var db = new BazaProjekta2())
                    {
                        db.Artikli.Attach(uklonjeni);
                        uklonjeni.kolicina = 0;
                        db.SaveChanges();
                    }
                }
                
            }
            prikazRoka();
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pregled_roka_trajanja_Load(object sender, EventArgs e)
        {
            prikazRoka();
        }

        private void prikazRoka()
        {
            BindingList<Artikli> artikli = null;
            using (var db = new BazaProjekta2())
            {
                artikli = new BindingList<Artikli>(db.Artikli.ToList());
            }
            for (int i = 0; i < artikli.Count; i++)
            {
                if (artikli[i].rok_trajanja == null || artikli[i].kolicina == 0)
                {
                    artikli.RemoveAt(i);
                    i--;
                }
            }
            List<Artikli> sortiraniArtikli = artikli.OrderBy(x => x.rok_trajanja).ToList();
            dgbRok.DataSource = sortiraniArtikli;
        }
    }
}
