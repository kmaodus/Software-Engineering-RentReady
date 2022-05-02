using KlaseZaRentReady;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForma
{
    public partial class ZaposlenikForma : Form
    {
        ExportDgvToPDF export = new ExportDgvToPDF();
        public int ZaposlenikID = 1;
        public ZaposlenikForma(string korisnik)
        { 
            InitializeComponent();
            korisnickoImeLabel.Text = korisnik;
        }

        private void dodajStanaraButton_Click(object sender, EventArgs e)
        {
            VlasnikZaposlenikDodajStanaraForma vlasnikZaposlenikDodajStanaraForma = new VlasnikZaposlenikDodajStanaraForma(stanariDataGrid);
            vlasnikZaposlenikDodajStanaraForma.Show();
        }

        private void ZaposlenikForma_Load(object sender, EventArgs e)
        {
            this.stanTableAdapter.Fill(this.dB_18082.Stan);
            this.katTableAdapter.Fill(this.dB_18082.Kat);
            this.ulazTableAdapter.Fill(this.dB_18082.Ulaz);
            this.stanTableAdapter.Fill(this.dB_18082.Stan);
            this.katTableAdapter.Fill(this.dB_18082.Kat);
            this.ulazTableAdapter.Fill(this.dB_18082.Ulaz);
            this.vlasnikTableAdapter.Fill(this.dB_18082.Vlasnik);
            this.zgradaTableAdapter.FillByZaposlenikID(this.dB_18082.Zgrada, ZaposlenikID);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ZaposlenikForma_KeyUp);
            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                stanariDataGrid.DataSource = stanari.ToList();
            }
        }

        private void azurirajStanaraButton_Click(object sender, EventArgs e)
        {
            VlasnikIzmjeniStanaraForma vlasnikIzmjeniStanaraForma = new VlasnikIzmjeniStanaraForma(int.Parse(stanariDataGrid.CurrentRow.Cells[0].Value.ToString()), stanariDataGrid);
            vlasnikIzmjeniStanaraForma.Show();
        }

        private void brisiStanaraButton_Click(object sender, EventArgs e)
        {
            ProvjeraOdabiraBrisanjaForma provjeraOdabiraBrisanjaForma = new ProvjeraOdabiraBrisanjaForma(int.Parse(stanariDataGrid.CurrentRow.Cells[0].Value.ToString()), stanariDataGrid);
            provjeraOdabiraBrisanjaForma.Show();
        }

        private void kontaktirajStanaraButton_Click(object sender, EventArgs e)
        {
            EmailKontaktiranjeForma emailKontaktiranjeForma = new EmailKontaktiranjeForma("pi.projekt.test@gmail.com", "pitest2018", stanariDataGrid.CurrentRow.Cells[4].Value.ToString());
            emailKontaktiranjeForma.Show();
        }

        private void txtDodijeliPosaoZaposlenik_Click(object sender, EventArgs e)
        {
            DodijeliPosaoPopUpForma DodijeliPosao = new DodijeliPosaoPopUpForma(int.Parse(dgvPopisZgrada.SelectedRows[0].Cells[0].Value.ToString()));
            DodijeliPosao.ShowDialog();
        }
        /// <summary>
        /// Metoda koja se spaja na našu bazu na server te vraća podatke zadane upitom nad bazom
        /// </summary>
        /// <param name="SqlUpit"></param>
        /// <returns></returns>
        public DataTable DohvacanjePodatakaIzBaze(string SqlUpit)
        {
            SqlConnection con = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=18082_DB;Persist Security Info=True;User ID=18082_User;Password=jXfC+2]_");
            SqlDataAdapter sda = new SqlDataAdapter(SqlUpit, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        // Metode nad promjenom "ComboBox"-a koje služe za ispisivanje različitih rezultata ovisno što je korisnik odabrao
        // Metode nad promjenom "ComboBox"-a koje služe za ispisivanje različitih rezultata ovisno što je korisnik odabrao
        private void cbZgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKatovi.Enabled = false;
            cbStanovi.Enabled = false;
            if (cbZgrade.SelectedValue != null)
            {
                cbUlazi.Enabled = true;
                int zgradaID = int.Parse(cbZgrade.SelectedValue.ToString());
                ulazTableAdapter.FillByZgradaID(this.dB_18082.Ulaz, zgradaID);
                string SqlUpit = @" SELECT Ulaz.Oznaka AS OznakaUlaza, Kat.Oznaka AS OznakaKata, Stan.Oznaka AS OznakaStana, Stan.Dugovanje
                                    FROM Zgrada INNER JOIN
                                    Ulaz ON Zgrada.ID = Ulaz.ZgradaID INNER JOIN
                                    Kat ON Ulaz.ID = Kat.UlazID INNER JOIN
                                    Stan ON Kat.ID = Stan.KatID
                                    WHERE(Zgrada.ID = " + zgradaID + ")";
                dgvPopisTroskova.DataSource = DohvacanjePodatakaIzBaze(SqlUpit);
            }
        }
        private void cbUlazi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStanovi.Enabled = false;
            if (cbUlazi.SelectedValue != null)
            {
                cbKatovi.Enabled = true;
                int ulazID = int.Parse(cbUlazi.SelectedValue.ToString());
                katTableAdapter.FillByUlazID(this.dB_18082.Kat, ulazID);
                string SqlUpit = @" SELECT Kat.Oznaka AS OznakaKata, Stan.Oznaka AS OznakaStana, Stan.Dugovanje
                                    FROM Ulaz INNER JOIN
                                    Kat ON Ulaz.ID = Kat.UlazID INNER JOIN
                                    Stan ON Kat.ID = Stan.KatID
                                    WHERE(Ulaz.ID =" + ulazID + ")";
                dgvPopisTroskova.DataSource = DohvacanjePodatakaIzBaze(SqlUpit);
            }
        }

        private void cbKatovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKatovi.SelectedValue != null)
            {
                cbStanovi.Enabled = true;
                int katID = int.Parse(cbKatovi.SelectedValue.ToString());
                stanTableAdapter.FillBykatID(this.dB_18082.Stan, katID);
                string SqlUpit = @" SELECT Stan.Oznaka AS OznakaStana, Stan.Dugovanje
                                    FROM Kat INNER JOIN
                                    Stan ON Kat.ID = Stan.KatID
                                    WHERE(Kat.ID =" + katID + ")";
                dgvPopisTroskova.DataSource = DohvacanjePodatakaIzBaze(SqlUpit);
            }
        }

        private void cbStanovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStanovi.SelectedValue != null)
            {
                int stanID = int.Parse(cbStanovi.SelectedValue.ToString());
                string SqlUpit = @" SELECT Dugovanje
                                    FROM Stan 
                                    WHERE(ID =" + stanID + ")";
                dgvPopisTroskova.DataSource = DohvacanjePodatakaIzBaze(SqlUpit);
            }
        }

        // Ispisi iz tablica u PDF
        private void btnIspisTroskovaUPDF_Click(object sender, EventArgs e)
        {
            export.ExportToPDF(dgvPopisTroskova, cbZgrade);
        }
        /// <summary>
        /// Pritiskom tikpke F1 u bilo koje trenutku pokazati će se poruka "Pomoć" koja je za svaki dio aplikacije drugačija te pobliže objašnjava korisniku kako koristiti određeni dio aplikacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZaposlenikForma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                if (tabControl1.SelectedTab.Text == "Zaposlenici")
                {
                    MessageBox.Show("U ovom dijelu programa možete pogledati popis zaposlenika te pritiskom na gumb 'Kontaktiraj' odabranom zaposleniku možete poslati mail.", "Pomoć");
                }
                if (tabControl1.SelectedTab.Text == "Zgrade")
                {
                    MessageBox.Show("U ovom dijelu programa možete pogledati popis zgrada koje su Vama dodijeljene te pritiskom na gumb 'Dodijeli posao' možete odabranoj zgradi dodijeliti posao.", "Pomoć");
                }
                if (tabControl1.SelectedTab.Text == "Stanari")
                {
                    MessageBox.Show("U ovom dijelu programa možete pogledati popis stanara zgrada koje su Vama dodijeljene te pritiskom na gumbove 'Dodaj', 'Ažuriraj', 'Briši' i 'Kontaktiraj' možete obaviti istoimenu radnju za odabranog stanara.", "Pomoć");
                }
                if (tabControl1.SelectedTab.Text == "Izvještaji")
                {
                    MessageBox.Show("U ovom dijelu programa možete pogledati popis svih torškova koje su Vama dodijeljene te filtrirati podatke po zgradama, ulazima, katovima i stanovima. Također, možete pritiskom na gumb 'PDF' te podatke dobiti ispisane u tablici u PDF datoteci.", "Pomoć");
                }

            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            PrijavaForma prijavaForma = new PrijavaForma();
            prijavaForma.ShowDialog();
        }

        private void prikaziSveStanareButton_Click(object sender, EventArgs e)
        {
            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                stanariDataGrid.DataSource = stanari.ToList();
            }
            uvjetTrazenjaStanaraTextBox.Clear();
        }

        /// <summary>
        /// Pretrazuje tablicu stanari prema unesenom tekstu u textbox iznad gumba
        /// </summary>
        private void traziStanaraButton_Click(object sender, EventArgs e)
        {
            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                //stanariDataGrid.DataSource = stanari.ToList();
                var pronadjeniStanari = stanari.Where(x => x.Ime == uvjetTrazenjaStanaraTextBox.Text || x.Prezime == uvjetTrazenjaStanaraTextBox.Text ||
                x.Grad == uvjetTrazenjaStanaraTextBox.Text || x.PostanskiBroj == uvjetTrazenjaStanaraTextBox.Text || x.OIB == uvjetTrazenjaStanaraTextBox.Text || x.IBAN == uvjetTrazenjaStanaraTextBox.Text).ToList();
                stanariDataGrid.DataSource = pronadjeniStanari;
            }
        }

        private void prikaziDugovanjaButton_Click(object sender, EventArgs e)
        {
            List<int> listaIdDuznihStanara = new List<int>();
            string sqlUpit = @"SELECT StanarID FROM Stan WHERE (Dugovanje > 0)";
            DataTable idStanaraKojiDuguju = DohvacanjePodatakaIzBaze(sqlUpit);

            for (int i = 0; i < idStanaraKojiDuguju.Rows.Count; i++)
            {
                listaIdDuznihStanara.Add(Convert.ToInt32(idStanaraKojiDuguju.Rows[i]["StanarID"]));
            }

            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                int prviID = listaIdDuznihStanara[0];

                var pronadjeniStanari = stanari.Where(x => x.ID == prviID).ToList();
                foreach (int item in listaIdDuznihStanara)
                {
                    if (item == listaIdDuznihStanara[0])
                    {
                        continue;
                    }
                    else
                    {
                        var trenutniStanari = stanari.Where(x => x.ID == item).ToList();
                        pronadjeniStanari = pronadjeniStanari.Concat(trenutniStanari).ToList();
                    }
                }

                stanariDataGrid.DataSource = pronadjeniStanari;
            }

            return;
        }

        private void noviMjesecButton_Click(object sender, EventArgs e)
        {
            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                var listaStanara = stanari.ToList();

                foreach (Stanar item in listaStanara)
                {
                    if (item.IznosStanarine == null) continue;
                    string connectionString = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("UPDATE Stan SET Dugovanje= Dugovanje + @p1 WHERE StanarID = @p2", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("p1", item.IznosStanarine);
                    sqlCommand.Parameters.AddWithValue("p2", item.ID);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            MessageBox.Show("Uspješno unesena nova dugovanja.");
        }

        private void placenoDugovanjeButton_Click(object sender, EventArgs e)
        {
            PlacenoDugovanjeForma placenoDugovanjeForma = new PlacenoDugovanjeForma(int.Parse(stanariDataGrid.CurrentRow.Cells[0].Value.ToString()), float.Parse(stanariDataGrid.CurrentRow.Cells[10].Value.ToString()));
            placenoDugovanjeForma.Show();
        }
    }
}
