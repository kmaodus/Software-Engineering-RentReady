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
    public partial class DodavanjeZgrade : Form
    {
        private bool uredivanje = false;
        private int vlasnikID = 1;
        public DodavanjeZgrade()
        {
            InitializeComponent();
            uredivanje = false;
            btnDodaj.Text = "Dodaj";
        }

        public DodavanjeZgrade(int zgradaId)
        {
            InitializeComponent();
            uredivanje = true;
            btnDodaj.Text = "Uredi";
            this.zgradaTableAdapter.FillByZgradaID(this.dB_18082.Zgrada, zgradaId);
        }

        public void DodajZgradu()
        {
            zgradaTableAdapter.Insert(vlasnikID, int.Parse(cbZaposlenik.SelectedValue.ToString()), txtLokacija.Text);
        }

        public void UrediZgradu()
        {
            this.Validate();
            this.zgradaBindingSource.EndEdit();
            this.zgradaTableAdapter.Update(dB_18082.Zgrada);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtLokacija.Text == null)
            {
                MessageBox.Show("Molimo vas unesite lokaciju!", "Neispravna lokacija");
            }
            else
            {
                if (!uredivanje)
                {
                    DodajZgradu();
                }
                else
                {
                    UrediZgradu();
                }

                this.Close();
            }
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodavanjeZgrade_Load(object sender, EventArgs e)
        {
            this.zaposlenikTableAdapter.Fill(this.dB_18082.Zaposlenik);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(DodavanjeZgrade_KeyUp);

        }

        private void DodavanjeZgrade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                MessageBox.Show("Ova forma nam služi za dodavanje nove zgrade, popunite podatke te pritiskom na gumb 'Dodaj' ili 'Uredi' ćete dodati novu zgradu, odnosno, urediti već postojeću.", "Pomoć");
            }
        }
    }
}
