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
    public partial class DodajPosao : Form
    {
        private bool uredivanje = false;

        public DodajPosao()
        {
            InitializeComponent();
            uredivanje = false;
            btnDodajPosao.Text = "Dodaj";
        }
        public DodajPosao(int posaoId)
        {
            InitializeComponent();
            uredivanje = true;
            btnDodajPosao.Text = "Uredi";
            this.mogucPosaoTableAdapter.FillByPosaoID(this.dB_18082.MogucPosao, posaoId);
        }

        public void MetodaDodajPosao()
        {
            this.mogucPosaoTableAdapter.Insert(txtNazivPosla.Text, txtOpisPosla.Text);
        }

        public void UrediPosao()
        {
            this.Validate();
            this.mogucPosaoBindingSource.EndEdit();
            this.mogucPosaoTableAdapter.Update(this.dB_18082.MogucPosao);
        }

        private void btnDodajPosao_Click(object sender, EventArgs e)
        {
            if (txtNazivPosla.Text == null)
            {
                MessageBox.Show("Molimo Vas unesite naziv posla!", "Neispravan unos naziva");
            }
            else
            {
                if (!uredivanje)
                {
                    MetodaDodajPosao();
                }
                else
                {
                    UrediPosao();
                }
                this.Close();
            }
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPosao_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(DodajPosao_KeyUp);
        }

        private void DodajPosao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                MessageBox.Show("Ova forma nam služi za dodavanje novog posla, popunite podatke te pritiskom na gumb 'Dodaj' ćete dodati novi posao", "Pomoć");
            }
        }
    }
}
