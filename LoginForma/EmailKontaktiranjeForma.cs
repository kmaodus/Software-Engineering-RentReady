using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailClassLibrary;

namespace LoginForma
{
    public partial class EmailKontaktiranjeForma : Form
    {
        string posiljateljPoruke;
        string lozinkaPosiljatelja;
        string primateljPoruke;
        public EmailKontaktiranjeForma(string posiljatelj, string lozinka, string primatelj)
        {
            InitializeComponent();
            posiljateljPoruke = posiljatelj;
            lozinkaPosiljatelja = lozinka;
            primateljPoruke = primatelj;

            primateljTextBox.Text = primateljPoruke;
        }

        private void posaljiEmailButton_Click(object sender, EventArgs e)
        {
            Email email = new Email("pi.projekt.test@gmail.com", "pitest2018", primateljTextBox.Text, predmetTextBox.Text, porukaTextBox.Text);
            try
            {
                email.Send();
                MessageBox.Show("Poruka uspješno poslana.");
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspješno slanje poruke!");
            }

        }
    }
}
