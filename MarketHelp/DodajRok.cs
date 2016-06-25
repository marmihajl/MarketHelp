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
    public partial class DodajRok : Form
    {
        Artikli artikl = null;
        public DodajRok(Artikli a)
        {
            InitializeComponent();
            artikl = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DateTime.Compare(dateTimePicker1.Value, DateTime.Today) > 0)
            {
                using (var db2 = new BazaProjekta2())
                {
                    db2.Artikli.Attach(artikl);
                    artikl.rok_trajanja = dateTimePicker1.Value.Date;
                    db2.SaveChanges();
                }
            }
            else if(DateTime.Compare(dateTimePicker1.Value, DateTime.Today) < 0)
            {
                MessageBox.Show("Datum isteka roka trajanja ne smije biti manji od današnjeg dana");
                return;
            }
            else
            {
                using (var db = new BazaProjekta2())
                {
                    db.Artikli.Attach(artikl);
                    artikl.rok_trajanja = null;
                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
