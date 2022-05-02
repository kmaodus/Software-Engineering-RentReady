using System;
using System.Net;
using System.Net.Mail;

namespace MailClassLibrary
{
    /// <summary>
    /// Klasa koja predstavlja Email objekt s metodom za slanje istog, iskljucivo za gmail accountove
    /// </summary>
    public class Email
    {
        public string senderEmail { get; set; }
        public string senderPassword { get; set; }
        public string recieverEmail { get; set; }
        public string subjectEmail { get; set; }
        public string bodyEmail { get; set; }
        public Email(string sender, string password, string reciever, string subject, string body)
        {
            senderEmail = sender;
            senderPassword = password;
            recieverEmail = reciever;
            subjectEmail = subject;
            bodyEmail = body;
            
        }

        /// <summary>
        /// Metoda za slanje maila koji je prethodno popunjen s podacima
        /// </summary>
        public void Send()
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(senderEmail, senderPassword);
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(recieverEmail);
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.Subject = subjectEmail;
            mailMessage.Body = bodyEmail;
            client.Send(mailMessage);
        }
    }
}
