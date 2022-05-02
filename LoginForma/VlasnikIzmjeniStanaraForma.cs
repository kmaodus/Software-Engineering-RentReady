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
    public partial class VlasnikIzmjeniStanaraForma : Form
    {
        List<PictureBox> errorImageList;
        int indexStanara;
        DataGridView stanariGrid;
        Stanar stanar;
        public VlasnikIzmjeniStanaraForma(int index, DataGridView dataGrid)
        {
            InitializeComponent();
            indexStanara = index;
            stanariGrid = dataGrid;

        }

        private void VlasnikIzmjeniStanaraForma_Load(object sender, EventArgs e)
        {
            neispravanUnosLabel.Hide();
            errorImageList = new List<PictureBox>();
            errorImageList.Add(errorPictureIme);
            errorImageList.Add(errorPicturePrezime);
            errorImageList.Add(errorPictureOIB);
            errorImageList.Add(errorPictureEmail);
            errorImageList.Add(errorPictureAdresa);
            errorImageList.Add(errorPictureGrad);
            errorImageList.Add(errorPicturePostanski);
            errorImageList.Add(errorPictureIBAN);

            using (StanarEntities context = new StanarEntities())
            {
                stanar = context.Stanars.FirstOrDefault(s => s.ID == indexStanara);
                imeTextBox.Text = stanar.Ime;
                prezimeTextBox.Text = stanar.Prezime;
                oibTextBox.Text = stanar.OIB;
                emailTextBox.Text = stanar.Email;
                lozinkaTextBox.Text = stanar.Lozinka;
                adresaTextBox.Text = stanar.Adresa;
                gradTextBox.Text = stanar.Grad;
                postanskiTextBox.Text = stanar.PostanskiBroj;
                ibanTextBox.Text = stanar.IBAN;
                stanarinaTextBox.Text = stanar.IznosStanarine.ToString();
            }

            FilledDataSet filledStan = new FilledDataSet("SELECT * FROM Stan WHERE StanarID =" + stanar.ID.ToString());
            string datum = filledStan.dataSet.Tables[0].Rows[0]["IznajmljenDoDatuma"].ToString();
            string[] vrijednostiDatuma = datum.Split('/', ' ');
            int godina = int.Parse(vrijednostiDatuma[2]);
            int mjesec = int.Parse(vrijednostiDatuma[1]);
            int dan = int.Parse(vrijednostiDatuma[0]);
            //DateTime dateTime = new DateTime(godina, mjesec, dan);

            //prikazStanovaComboBox.DataSource = filledStan.dataSet.Tables[0];
            //prikazStanovaComboBox.DisplayMember = "ID";

            FilledDataSet filledZgrada = new FilledDataSet("SELECT * FROM Zgrada");
            prikazZgradaComboBox.DataSource = filledZgrada.dataSet.Tables[0];
            prikazZgradaComboBox.DisplayMember = "ID";
        }

        private void spremiStanara_Click(object sender, EventArgs e)
        {
            neispravanUnosLabel.Hide();
            foreach (PictureBox item in errorImageList)
            {
                if (item.Visible)
                {
                    neispravanUnosLabel.Show();
                    return;
                }
            }

            using (StanarEntities context = new StanarEntities())
            {

                stanar = context.Stanars.FirstOrDefault(s => s.ID == indexStanara);

                if (string.IsNullOrEmpty(imeTextBox.Text))
                {
                    MessageBox.Show("Nisu uneseni svi potrebni podaci!");
                    return;
                }
                if (string.IsNullOrEmpty(prezimeTextBox.Text))
                {
                    MessageBox.Show("Nisu uneseni svi potrebni podaci!");
                    return;
                }
                if (string.IsNullOrEmpty(oibTextBox.Text))
                {
                    MessageBox.Show("Nisu uneseni svi potrebni podaci!");
                    return;
                }
                if (string.IsNullOrEmpty(emailTextBox.Text))
                {
                    MessageBox.Show("Nisu uneseni svi potrebni podaci!");
                    return;
                }
                if (string.IsNullOrEmpty(ibanTextBox.Text))
                {
                    MessageBox.Show("Nisu uneseni svi potrebni podaci!");
                    return;
                }

                try
                {
                    stanar.Ime = imeTextBox.Text;
                    stanar.Prezime = prezimeTextBox.Text;
                    stanar.OIB = oibTextBox.Text;
                    stanar.Email = emailTextBox.Text;
                    stanar.Lozinka = lozinkaTextBox.Text;
                    stanar.Adresa = adresaTextBox.Text;
                    stanar.Grad = gradTextBox.Text;
                    stanar.PostanskiBroj = postanskiTextBox.Text;
                    stanar.IBAN = ibanTextBox.Text;
                    stanar.IznosStanarine = float.Parse(stanarinaTextBox.Text);
                }
                catch (Exception) { };

                context.SaveChanges();

                MessageBox.Show("Stanar uspješno izmjenjen.");
            }

            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                stanariGrid.DataSource = stanari.ToList();
            }

            //IZMJENA PODATAKA U TABLICI STAN

            string connectionString = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("UPDATE Stan SET StanarID=@p1 , StanIznajmljen=@p2 , IznajmljenDoDatuma=@p3 , Dugovanje=@p5 WHERE ID=@p4", sqlConnection);
            sqlCommand.Parameters.AddWithValue("p1", indexStanara);
            sqlCommand.Parameters.AddWithValue("p2", "Da");
            sqlCommand.Parameters.AddWithValue("p3", DateTime.Parse(krajBoravkaDateTimePicker.Text));
            sqlCommand.Parameters.AddWithValue("p4", int.Parse(prikazStanovaComboBox.Text));
            sqlCommand.Parameters.AddWithValue("p5", float.Parse(stanarinaTextBox.Text));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();


        }

        private void prikazZgradaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilledDataSet filledUlaz = new FilledDataSet("SELECT * FROM Ulaz WHERE ZgradaID = " + prikazZgradaComboBox.Text);
                prikazUlazaComboBox.DataSource = filledUlaz.dataSet.Tables[0];
                prikazUlazaComboBox.DisplayMember = "ID";

                FilledDataSet filledKat = new FilledDataSet("SELECT * FROM Kat WHERE UlazID = " + prikazUlazaComboBox.Text);
                prikazKatovaComboBox.DataSource = filledKat.dataSet.Tables[0];
                prikazKatovaComboBox.DisplayMember = "ID";

                FilledDataSet filledStan = new FilledDataSet("SELECT * FROM Stan WHERE KatID = " + prikazKatovaComboBox.Text);
                prikazStanovaComboBox.DataSource = filledStan.dataSet.Tables[0];
                prikazStanovaComboBox.DisplayMember = "ID";
            }
            catch (Exception)
            {


            }
        }

        private void prikazUlazaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilledDataSet filledKat = new FilledDataSet("SELECT * FROM Kat WHERE UlazID = " + prikazUlazaComboBox.Text);
                prikazKatovaComboBox.DataSource = filledKat.dataSet.Tables[0];
                prikazKatovaComboBox.DisplayMember = "ID";

                FilledDataSet filledStan = new FilledDataSet("SELECT * FROM Stan WHERE KatID = " + prikazKatovaComboBox.Text);
                prikazStanovaComboBox.DataSource = filledStan.dataSet.Tables[0];
                prikazStanovaComboBox.DisplayMember = "ID";
            }
            catch (Exception)
            {


            }
        }

        private void prikazKatovaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilledDataSet filledStan = new FilledDataSet("SELECT * FROM Stan WHERE KatID = " + prikazKatovaComboBox.Text);
                prikazStanovaComboBox.DataSource = filledStan.dataSet.Tables[0];
                prikazStanovaComboBox.DisplayMember = "ID";
            }
            catch (Exception)
            {


            }
        }

        private void imeTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            foreach (char item in imeTextBox.Text)
            {
                if (char.IsLetter(item) != true) validEntry = false;
            }

            if (validEntry && !string.IsNullOrEmpty(imeTextBox.Text)) errorPictureIme.Hide();
            else errorPictureIme.Show();
        }

        private void prezimeTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            foreach (char item in prezimeTextBox.Text)
            {
                if (char.IsLetter(item) != true) validEntry = false;
            }

            if (validEntry && !string.IsNullOrEmpty(prezimeTextBox.Text)) errorPicturePrezime.Hide();
            else errorPicturePrezime.Show();
        }

        private void oibTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            foreach (char item in oibTextBox.Text)
            {
                if (char.IsDigit(item) != true) validEntry = false;
            }

            if (validEntry && (oibTextBox.Text.Length == 11)) errorPictureOIB.Hide();
            else errorPictureOIB.Show();
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            if (emailTextBox.Text.Contains("@") && emailTextBox.Text.Contains(".") && emailTextBox.Text.Length > 6) validEntry = true;
            else validEntry = false;

            if (validEntry) errorPictureEmail.Hide();
            else errorPictureEmail.Show();
        }

        private void adresaTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            if (adresaTextBox.Text.Count() < 3) validEntry = false;
            else validEntry = true;

            if (validEntry) errorPictureAdresa.Hide();
            else errorPictureAdresa.Show();
        }

        private void gradTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            foreach (char item in gradTextBox.Text)
            {
                if (char.IsLetter(item) != true) validEntry = false;
            }

            if (validEntry && string.IsNullOrEmpty(gradTextBox.Text) == false) errorPictureGrad.Hide();
            else errorPictureGrad.Show();
        }

        private void postanskiTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;

            foreach (char item in postanskiTextBox.Text)
            {
                if (char.IsDigit(item) != true) validEntry = false;
            }

            if (validEntry && (postanskiTextBox.Text.Length == 5)) errorPicturePostanski.Hide();
            else errorPicturePostanski.Show();
        }

        private void ibanTextBox_Leave(object sender, EventArgs e)
        {
            bool validEntry = true;
            int i = 0;

            if (!char.IsUpper(ibanTextBox.Text[0]) || !char.IsUpper(ibanTextBox.Text[0])) validEntry = false;

            foreach (char item in ibanTextBox.Text)
            {
                i++;
                if (i > 2)
                {
                    if (!char.IsLetterOrDigit(item)) validEntry = false;
                }
            }

            if (validEntry && ibanTextBox.Text.Count() > 10) errorPictureIBAN.Hide();
            else errorPictureIBAN.Show();
        }
    }
}
