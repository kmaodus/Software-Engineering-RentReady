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
    public partial class DodijeliPosaoPopUpForma : Form
    {
        public int zgradaID;
        public DodijeliPosaoPopUpForma(int zgradaId)
        {
            InitializeComponent();
            zgradaID = zgradaId;
        }

        private void DodijeliPosaoPopUpForma_Load(object sender, EventArgs e)
        {
            this.ugovorenPosaoTableAdapter.Fill(this.dB_18082.UgovorenPosao);
            this.partnerTableAdapter.Fill(this.dB_18082.Partner);
            this.mogucPosaoTableAdapter.Fill(this.dB_18082.MogucPosao);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(DodijeliPosaoPopUpForma_KeyUp);

        }

        private void btnDodajPosao_Click(object sender, EventArgs e)
        {
            DodajPosao dodajPosao = new DodajPosao();
            dodajPosao.ShowDialog();
            this.mogucPosaoTableAdapter.Fill(this.dB_18082.MogucPosao);
        }

        private void btnAzurirajPosao_Click(object sender, EventArgs e)
        {
            if(dgvPopisPoslova.SelectedRows.Count != 0)
            {
                DodajPosao dodajPosao = new DodajPosao(int.Parse(dgvPopisPoslova.SelectedRows[0].Cells[0].Value.ToString()));
                dodajPosao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Molimo odaberite neki posao!", "Posao nije odabran");
            }
           
            this.mogucPosaoTableAdapter.Fill(this.dB_18082.MogucPosao);

        }

        private void btnObrisiPosao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li stvarno obrisati ovaj posao?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvPopisPoslova.Rows.RemoveAt(dgvPopisPoslova.CurrentRow.Index);
                mogucPosaoTableAdapter.Update(this.dB_18082.MogucPosao);
            }
        }

        private void btnDodajPartnera_Click(object sender, EventArgs e)
        {
            DodajPartnera dodajPartnera = new DodajPartnera();
            dodajPartnera.ShowDialog();
            this.partnerTableAdapter.Fill(this.dB_18082.Partner);
        }

        private void btnAzurirajPartnera_Click(object sender, EventArgs e)
        {
            if (dgvPopisPartnera.SelectedRows.Count != 0)
            {
                this.mogucPosaoTableAdapter.Fill(this.dB_18082.MogucPosao);
                DodajPartnera dodajPartnera = new DodajPartnera(int.Parse(dgvPopisPartnera.SelectedRows[0].Cells[0].Value.ToString()));
                dodajPartnera.ShowDialog();
            }
            else
            {
                MessageBox.Show("Molimo odaberite nekog partnera!", "Partner nije odabran");
            }
            this.partnerTableAdapter.Fill(this.dB_18082.Partner);
        }

        private void btnObrisiPartnera_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li stvarno obrisati ovag partnera?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvPopisPartnera.Rows.RemoveAt(dgvPopisPartnera.CurrentRow.Index);
                partnerTableAdapter.Update(this.dB_18082.Partner);
            }
        }

        private void btnDodijeliPosao_Click(object sender, EventArgs e)
        {
            if (dtpDatumPocetkaPosla.Value >= dtpDatumZavrsetkaPosla.Value)
            {
                MessageBox.Show("Datum završetka je niži od datuma početka", "Neispravan unos datuma");
            }
            else
            {
                if (dgvPopisPartnera.SelectedRows.Count == 0 || dgvPopisPoslova.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nije odabran partner i/ili posao", "Neispravan unos parntera/posla");
                }
                else
                {
                    double d;
                    if (!(double.TryParse(txtCijenaPosla.Text, out d))) 
                    {
                        MessageBox.Show("Molimo Vas unesite ispravnu cijenu!", "Neispravan unos cijene");
                    }
                    else
                    {
                        this.ugovorenPosaoTableAdapter.Insert(zgradaID, int.Parse(dgvPopisPartnera.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(dgvPopisPoslova.SelectedRows[0].Cells[0].Value.ToString()), double.Parse(txtCijenaPosla.Text), dtpDatumPocetkaPosla.Value, dtpDatumZavrsetkaPosla.Value);
                        MessageBox.Show("Uspješno dodan posao!");
                    }
                }
                
            }

        }

        private void DodijeliPosaoPopUpForma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                MessageBox.Show("Dodijeljivanje novog posla po zgradama. S lijeve strane možete vidjeti popis svih poslova, a uz priložene gumbe možeze dodavati, brisati ili ažurirati poslove, s desne strane isto to samo za partnere. Kada odaberete posao i partnera u odgovarajuća polja unosite datum početka i datum završetka radove te cijelu istih. Na kraju pritiskom na gumb 'Dodijeli' dodijeljujete posao prethodno odabranoj zgradi!", "Pomoć");
            }
        }

        private void btnPregledPoslovaPoZgradi_Click(object sender, EventArgs e)
        {
            Form forma = new PregledPremaOdabranomPosluForma(int.Parse(dgvPopisPoslova.SelectedRows[0].Cells[0].Value.ToString()));
            forma.ShowDialog();
        }

        private void btnPregledPremaOdabranomPartneru_Click(object sender, EventArgs e)
        {
            Form forma = new PregledPremaOdabranomPartneruForma(int.Parse(dgvPopisPartnera.SelectedRows[0].Cells[0].Value.ToString()));
            forma.ShowDialog();
        }

        private void txtPretragaPosla_KeyUp(object sender, KeyEventArgs e)
        {
            string pretraga = "%" + txtPretragaPosla.Text + "%";
            this.mogucPosaoTableAdapter.FillByNaziv(this.dB_18082.MogucPosao, pretraga);
        }

        private void txtPretragaPartnera_KeyUp(object sender, KeyEventArgs e)
        {
            string pretraga = "%" + txtPretragaPartnera.Text + "%";
            this.partnerTableAdapter.FillByNaziv(this.dB_18082.Partner, pretraga);
        }
    }
}
