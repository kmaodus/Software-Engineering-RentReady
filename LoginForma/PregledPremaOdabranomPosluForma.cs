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
    public partial class PregledPremaOdabranomPosluForma : Form
    {
        private int posaoId;
        public PregledPremaOdabranomPosluForma(int idPosao)
        {
            InitializeComponent();
            posaoId = idPosao;
        }

        private void PregledPoslovaPoZgradiForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_18082.Zgrada' table. You can move, or remove it, as needed.
            this.zgradaTableAdapter.Fill(this.dB_18082.Zgrada);
            // TODO: This line of code loads data into the 'dB_18082.MogucPosao' table. You can move, or remove it, as needed.
            this.mogucPosaoTableAdapter.Fill(this.dB_18082.MogucPosao);
            // TODO: This line of code loads data into the 'dB_18082.Partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dB_18082.Partner);
            // TODO: This line of code loads data into the 'dB_18082.UgovorenPosao' table. You can move, or remove it, as needed.
            this.ugovorenPosaoTableAdapter.FillByPosaoId(this.dB_18082.UgovorenPosao, posaoId);

        }
    }
}
