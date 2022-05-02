using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForma
{
    public partial class ProvjeraOdabiraBrisanjaForma : Form
    {
        DataGridView stanariGrid;
        int indexStanara;
        public ProvjeraOdabiraBrisanjaForma(int index, DataGridView dataGrid)
        {
            InitializeComponent();
            stanariGrid = dataGrid;
            indexStanara = index;
        }

        private void neButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void daButton_Click(object sender, EventArgs e)
        {
            using(StanarEntities context = new StanarEntities())
            {
                Stanar stanar = context.Stanars.FirstOrDefault(s => s.ID == indexStanara);
                context.Stanars.Remove(stanar);

                context.SaveChanges();

                var stanari = context.Stanars;
                stanariGrid.DataSource = stanari.ToList();
            }

            Close();
        }
    }
}
