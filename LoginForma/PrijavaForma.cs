using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BunifuAnimatorNS;
using MailClassLibrary;

namespace LoginForma
{
    public partial class PrijavaForma : Form
    {

        
        public PrijavaForma()
        {
            InitializeComponent();
            //temp = forma1;
            bunifuTransition1.Show(panelPrijava, false, new Animation());
        }

        private void btnPrebaciNaRegistraciju_Click(object sender, EventArgs e)
        {
            RegistracijaForma nova = new RegistracijaForma(this);
            Hide();
            nova.Show();
        }

        private void lblPrijavaExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnPrijava_click(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("KorisnickoIme",bunifuPrijavaKorIme.Text));
            sqlParams.Add(new SqlParameter("Lozinka", bunifuPrijavaLozinka.Text));

            DataTable dtLoginRezultatiVlasnik = DAL.DAL.IzvrsiSP("ValidacijaVlasnika", sqlParams);
            if (dtLoginRezultatiVlasnik.Rows.Count == 1)
            {
                //Login vlasnika je valjan
                string korisnik = dtLoginRezultatiVlasnik.Rows[0]["KorisnickoIme"].ToString();
                //MessageBox.Show($"Prijavljeni ste uspješno kao {korisnik} ");

                VlasnikaForma nova = new VlasnikaForma(korisnik);
                ShowInTaskbar = false;
                nova.ShowDialog();
                this.Close();
                
            }
            else
            {
                //Validacija zaposlenika
                //TODO: Dodana je validacija zaposlenika, ali moguće je smanjiti kolicinu koda!!! 
                List<SqlParameter> sqlParams2 = new List<SqlParameter>();
                sqlParams2.Add(new SqlParameter("KorisnickoIme", bunifuPrijavaKorIme.Text));
                sqlParams2.Add(new SqlParameter("Lozinka", bunifuPrijavaLozinka.Text));

                DataTable dtLoginRezultatiZaposlenik = DAL.DAL.IzvrsiSP("ValidacijaZaposlenika", sqlParams2);
                if (dtLoginRezultatiZaposlenik.Rows.Count == 1)
                {
                    //Login zaposlenika je valjan
                    string korisnik = dtLoginRezultatiZaposlenik.Rows[0]["KorisnickoIme"].ToString();
                    //MessageBox.Show($"Prijavljeni ste uspješno kao {korisnik} ");
                    ZaposlenikForma zaposlenikForma = new ZaposlenikForma(korisnik);
                    ShowInTaskbar = false;
                    zaposlenikForma.ShowDialog();
                    this.Close();
                }
                else
                {
                    //Login nije valjan
                    MessageBox.Show("Prijava nije uspjela! Provjerite unesene podatke");

                }                   
            }
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnZaboravljenaLozinka_Click(object sender, EventArgs e)
        {
            label10.Hide();
            bunifuPrijavaLozinka.Hide();
            btnZaboravljenaLozinka.Hide();
            btnPrijava.Hide();

            zaboravljenaLozinkaPorukaLabel.Show();
            zaboravljenaLozinkaPorukaLabel.Text = "Unesite svoje korisničko ime" + Environment.NewLine + "i dobiti ćete mail s vašim pristupnim" + Environment.NewLine + "podacima na račun koji ste naveli" + Environment.NewLine + "pri registraciji.";
            posaljiLozinkuButton.Visible = true;
            prijavaPovratakButton.Visible = true;
        }

        private void prijavaPovratakButton_Click(object sender, EventArgs e)
        {
            zaboravljenaLozinkaPorukaLabel.Hide();
            lozinkaJePoslanaLabel.Hide();
            posaljiLozinkuButton.Visible = false;
            prijavaPovratakButton.Visible = false;
            zaboravljenaLozinkaPorukaLabel.Visible = false;

            btnZaboravljenaLozinka.Show();
            btnPrijava.Show();
            label10.Show();
            bunifuPrijavaLozinka.Show();
        }

        private void posaljiLozinkuButton_Click(object sender, EventArgs e)
        {
            if(bunifuPrijavaKorIme.Text == "")
            {
                MessageBox.Show("Morate prvo unijeti traženo korisničko ime.");
                return;
            }

            string korisnickoIme = bunifuPrijavaKorIme.Text;
            Email email;
            DataSet dataSet = new DataSet();

            string strConnect = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection = new SqlConnection(strConnect);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Zaposlenik WHERE KorisnickoIme='" + korisnickoIme + "'", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            int i = dataSet.Tables[0].Rows.Count;

            if(i > 0)
            {
                string trazenaLozinka = dataSet.Tables[0].Rows[0]["Lozinka"].ToString();
                string trazenoIme = dataSet.Tables[0].Rows[0]["Ime"].ToString();
                string trazeniEmail = dataSet.Tables[0].Rows[0]["Email"].ToString();

                email = new Email("PI.Projekt.Test@gmail.com", "pitest2018", trazeniEmail, "Zaboravljena lozinka RentReady", "Pozdrav " + trazenoIme + ",\n\nOvo su Vaši pristupni podaci za račun u aplikaciji RentReady.\nKorisničko ime: " + bunifuPrijavaKorIme.Text + "\nLozinka: " + trazenaLozinka + "\n\nRentReady");
                email.Send();
                lozinkaJePoslanaLabel.Show();
            }
            else
            {
                sqlCommand = new SqlCommand("SELECT * FROM Vlasnik WHERE KorisnickoIme='" + korisnickoIme + "'", sqlConnection);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataSet);
                i = dataSet.Tables[0].Rows.Count;

                if(i > 0)
                {
                    string trazenaLozinka = dataSet.Tables[0].Rows[0]["Lozinka"].ToString();
                    string trazenoIme = dataSet.Tables[0].Rows[0]["Ime"].ToString();
                    string trazeniEmail = dataSet.Tables[0].Rows[0]["Email"].ToString();

                    email = new Email("PI.Projekt.Test@gmail.com", "pitest2018", trazeniEmail, "Zaboravljena lozinka RentReady", "Pozdrav " + trazenoIme + ",\n\nOvo su Vaši pristupni podaci za račun u aplikaciji RentReady.\nKorisničko ime: " + bunifuPrijavaKorIme.Text + "\nLozinka: " + trazenaLozinka + "\n\nRentReady");
                    email.Send();
                    lozinkaJePoslanaLabel.Show();
                }

                else
                {
                    MessageBox.Show("Ne postoji korisnik s navedenik korisničkim imenom.");
                }
            }
            sqlConnection.Close();
        }
    }
}
