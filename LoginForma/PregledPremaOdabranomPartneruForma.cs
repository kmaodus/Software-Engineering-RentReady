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
    public partial class PregledPremaOdabranomPartneruForma : Form
    {
        private int tvrtkaId;
        public PregledPremaOdabranomPartneruForma(int idTvrtka)
        {
            InitializeComponent();
            tvrtkaId = idTvrtka;
        }

        private void PregledPremaOdabranomPartneruForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_18082.Zgrada' table. You can move, or remove it, as needed.
            this.zgradaTableAdapter.Fill(this.dB_18082.Zgrada);
            // TODO: This line of code loads data into the 'dB_18082.UgovorenPosao' table. You can move, or remove it, as needed.
            this.ugovorenPosaoTableAdapter.FillByTvrtkaId(this.dB_18082.UgovorenPosao, tvrtkaId);
            // TODO: This line of code loads data into the 'dB_18082.MogucPosao' table. You can move, or remove it, as needed.
            this.mogucPosaoTableAdapter.Fill(this.dB_18082.MogucPosao);

        }
    }
}
