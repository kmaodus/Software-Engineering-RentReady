using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailClassLibrary;


namespace LoginForma
{
    public partial class RegistracijaForma : Form
    {
        PrijavaForma temp;

        public RegistracijaForma(PrijavaForma forma2)
        {
            InitializeComponent();
            bunifuRegistracijaIme.Focus();
            temp = forma2;
        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Close();
            temp.Show();
        }

        private void lblRegistracijaExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == false)
            {
                MessageBox.Show("Uvjeti korištenja moraju biti prihvaćeni kako bi nastavili s postupkom registracije.","Upozorenje");
                return;
            }
            string polje = bunifuRegistracijaKorIme.Text;

            DAL.ProvjeraKorIme handle = new DAL.ProvjeraKorIme();

            string konekcijaBaze = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";
            string upitZaVlasnika = "SELECT * FROM Vlasnik WHERE KorisnickoIme='" + polje + "'";
            string upitZaZaposlenika = "SELECT * FROM Zaposlenik WHERE KorisnickoIme='" + polje + "'";
           
            
            if (string.IsNullOrEmpty(bunifuRegistracijaKorIme.Text))
            {
                MessageBox.Show("Registracija nije uspjela! Provjerite unesene podatke", "Upozorenje",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (handle.Provjera(konekcijaBaze, upitZaVlasnika) || handle.Provjera(konekcijaBaze, upitZaZaposlenika))
            {
                MessageBox.Show("Korisničko ime već postoji!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrEmpty(bunifuRegistracijaOIB.Text))
                {
                    List<SqlParameter> sqlParamsVlasnika = new List<SqlParameter>();
                    sqlParamsVlasnika.Add(new SqlParameter("Ime", bunifuRegistracijaIme.Text));
                    sqlParamsVlasnika.Add(new SqlParameter("Prezime", bunifuRegistracijaPrezime.Text));
                    //sqlParamsVlasnika.Add(new SqlParameter("OIB", bunifuRegistracijaOIB.Text));
                    sqlParamsVlasnika.Add(new SqlParameter("KorisnickoIme", bunifuRegistracijaKorIme.Text));
                    sqlParamsVlasnika.Add(new SqlParameter("Lozinka", bunifuRegistracijaLozinka.Text));
                    sqlParamsVlasnika.Add(new SqlParameter("Email", bunifuRegistracijaEmail.Text));

                    DAL.DAL.IzvrsiSP("RegistracijaVlasnika", sqlParamsVlasnika);
                    MessageBox.Show("Registrirali ste uspješno.", "Informacija",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegistracija.Text = "Uspješno registriran!";

                    Email emailPotvrdeRegistracije = new Email("PI.Projekt.Test@gmail.com", "pitest2018", bunifuRegistracijaEmail.Text, "Potvrda registracije računa na RentReady aplikaciji.", $"Pozdrav {bunifuRegistracijaIme},\nUspješno ste se registrirali unutar sustava RentReady aplikacije.\nOvo su vaši pristupni podaci za rad.\nKorisničko ime: {bunifuRegistracijaKorIme}\nLozinka: {bunifuRegistracijaLozinka}\n\nRentReady");
                    emailPotvrdeRegistracije.Send();

                    this.Close();
                    temp.Show();
                    btnRegistracija.Text = "Registriraj se";
                }
                else
                {
                    List<SqlParameter> sqlParamsZaposlenika = new List<SqlParameter>();
                    sqlParamsZaposlenika.Add(new SqlParameter("Ime", bunifuRegistracijaIme.Text));
                    sqlParamsZaposlenika.Add(new SqlParameter("Prezime", bunifuRegistracijaPrezime.Text));
                    sqlParamsZaposlenika.Add(new SqlParameter("KorisnickoIme", bunifuRegistracijaKorIme.Text));
                    sqlParamsZaposlenika.Add(new SqlParameter("Lozinka", bunifuRegistracijaLozinka.Text));
                    sqlParamsZaposlenika.Add(new SqlParameter("OIB", bunifuRegistracijaOIB.Text));
                    sqlParamsZaposlenika.Add(new SqlParameter("Email", bunifuRegistracijaEmail.Text));

                    DAL.DAL.IzvrsiSP("RegistracijaZaposlenika", sqlParamsZaposlenika);
                     MessageBox.Show("Registrirali ste uspješno.", "Informacija",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegistracija.Text = "Uspješno registriran!";

                    Email emailPotvrdeRegistracije = new Email("PI.Projekt.Test@gmail.com", "pitest2018", bunifuRegistracijaEmail.Text, "Potvrda registracije računa na RentReady aplikaciji", $"Pozdrav {bunifuRegistracijaIme.Text},\n\nUspješno ste se registrirali unutar sustava RentReady aplikacije.\nOvo su vaši pristupni podaci za rad.\nKorisničko ime: {bunifuRegistracijaKorIme.Text}\nLozinka: {bunifuRegistracijaLozinka.Text}\n\nRentReady");
                    emailPotvrdeRegistracije.Send();

                    this.Close();
                    temp.Show();
                    btnRegistracija.Text = "Registriraj se";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ovo su uvjeti korištenja," +
                " ukoliko se slažete s njima potvrdite prihvaćanje kako bi se mogli registrirati u aplikaciju",
                "Uvjeti korištenja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                bunifuCheckbox1.Checked = true;
            }
            else
            {
                bunifuCheckbox1.Checked = false;
            }
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
