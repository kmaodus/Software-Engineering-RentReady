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
    public partial class VlasnikZaposlenikDodajStanaraForma : Form
    {
        DataGridView stanariGrid;
        List<PictureBox> errorImageList;
        int brojUnosa;
        public VlasnikZaposlenikDodajStanaraForma(DataGridView dataGrid)
        {
            InitializeComponent();
            stanariGrid = dataGrid;

            FilledDataSet filledZgrada = new FilledDataSet("SELECT * FROM Zgrada");
            prikazZgradaComboBox.DataSource = filledZgrada.dataSet.Tables[0];
            prikazZgradaComboBox.DisplayMember = "ID";
            
        }

        private void spremiStanara_Click(object sender, EventArgs e)
        {
            int uneseniStanarID;
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

                Stanar stanar = new Stanar();

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

                context.Stanars.Add(stanar);
                context.SaveChanges();

                imeTextBox.Clear();
                prezimeTextBox.Clear();
                oibTextBox.Clear();
                emailTextBox.Clear();
                lozinkaTextBox.Clear();
                adresaTextBox.Clear();
                gradTextBox.Clear();
                postanskiTextBox.Clear();
                ibanTextBox.Clear();

                MessageBox.Show("Stanar uspješno spremljen.");
            }

            using (StanarEntities context = new StanarEntities())
            {
                var stanari = context.Stanars;
                var novaListaStanara = stanari.ToList();
                stanariGrid.DataSource = novaListaStanara;
                
                uneseniStanarID = novaListaStanara[novaListaStanara.Count -1].ID;
            }

            //DODIJELJIVANJE STANARA POJEDINOM STANU

            string connectionString = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("UPDATE Stan SET StanarID=@p1 , StanIznajmljen=@p2 , IznajmljenDoDatuma=@p3 , Dugovanje=@p5 WHERE ID=@p4", sqlConnection);
            sqlCommand.Parameters.AddWithValue("p1", uneseniStanarID);
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VlasnikZaposlenikDodajStanaraForma_Load(object sender, EventArgs e)
        {
            neispravanUnosLabel.Hide();
            spremiStanara.Enabled = false;
            errorImageList = new List<PictureBox>();
            errorImageList.Add(errorPictureIme);
            errorImageList.Add(errorPicturePrezime);
            errorImageList.Add(errorPictureOIB);
            errorImageList.Add(errorPictureEmail);
            errorImageList.Add(errorPictureAdresa);
            errorImageList.Add(errorPictureGrad);
            errorImageList.Add(errorPicturePostanski);
            errorImageList.Add(errorPictureIBAN);

            brojUnosa = 0;
        }

        private void imeTextBox_Leave(object sender, EventArgs e)
        {
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
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
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
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
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
            bool validEntry = true;

            foreach(char item in oibTextBox.Text)
            {
                if (char.IsDigit(item) != true) validEntry = false;
            }

            if (validEntry && (oibTextBox.Text.Length == 11)) errorPictureOIB.Hide();
            else errorPictureOIB.Show();
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
            bool validEntry = true;

            if (emailTextBox.Text.Contains("@") && emailTextBox.Text.Contains(".") && emailTextBox.Text.Length > 6) validEntry = true;
            else validEntry = false;

            if (validEntry) errorPictureEmail.Hide();
            else errorPictureEmail.Show();
        }

        private void adresaTextBox_Leave(object sender, EventArgs e)
        {
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
            bool validEntry = true;

            if (adresaTextBox.Text.Count() < 3) validEntry = false;
            else validEntry = true;

            if (validEntry) errorPictureAdresa.Hide();
            else errorPictureAdresa.Show();
        }

        private void gradTextBox_Leave(object sender, EventArgs e)
        {
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
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
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
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
            if (++brojUnosa >= 8) spremiStanara.Enabled = true;
            bool validEntry = true;
            int i = 0;

            if (!char.IsUpper(ibanTextBox.Text[0]) || !char.IsUpper(ibanTextBox.Text[0])) validEntry = false;

            foreach (char item in ibanTextBox.Text)
            {
                i++;
                if(i > 2)
                {
                    if (!char.IsLetterOrDigit(item)) validEntry = false;
                }
            }

            if (validEntry && ibanTextBox.Text.Count() > 10) errorPictureIBAN.Hide();
            else errorPictureIBAN.Show();
        }
    }
    }
