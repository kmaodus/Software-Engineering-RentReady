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
    public partial class DodajPartnera : Form
    {
        private bool uredivanje = false;
        public DodajPartnera()
        {
            InitializeComponent();
            uredivanje = false;
            btnDodajPartnera.Text = "Dodaj";
        }
        public DodajPartnera(int partnerId)
        {
            InitializeComponent();
            uredivanje = true;
            btnDodajPartnera.Text = "Uredi";
            this.partnerTableAdapter.FillByPartnerID(this.dB_18082.Partner, partnerId);
        }

        public void MetodaDodajPartnera()
        {
            this.partnerTableAdapter.Insert(txtNazivPartnera.Text, txtEmailPartnera.Text, txtBrojMobitelaPartnera.Text);
        }

        public void UrediPartnera()
        {
            this.Validate();
            this.partnerBindingSource.EndEdit();
            this.partnerTableAdapter.Update(this.dB_18082.Partner);
        }


        private void btnDodajPartnera_Click(object sender, EventArgs e)
        {
            int d;
            if (!(int.TryParse(txtBrojMobitelaPartnera.Text, out d)) && txtEmailPartnera.Text != null && txtNazivPartnera != null)
            {
                MessageBox.Show("Molimo Vas unesite ispravne podatke!", "Neispravan unos");
            }
            else
            {
                if (!uredivanje)
                {

                    MetodaDodajPartnera();
                }
                else
                {
                    UrediPartnera();
                }
                this.Close();
            }
           
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPartnera_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(DodajPartnera_KeyUp);
        }

        private void DodajPartnera_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                MessageBox.Show("Ova forma nam služi za dodavanje novog partnera, popunite podatke te pritiskom na gumb 'Dodaj' ćete dodati novog partnera", "Pomoć");
            }
        }
    }
}
