using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SendCustomMail : Form
    {
        public string MailAddress { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }
        public SendCustomMail()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("dernektakip453@gmail.com", "mkyj fdic iueg cbbg");
                smtpClient.EnableSsl = true;

                ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dernektakip453@gmail.com");
                mail.To.Add(MailAddress);
                mail.Subject = txt_subject.Text;
                mail.Body = txt_body.Text;

                smtpClient.Send(mail);

                MessageBox.Show("E-posta başarıyla gönderildi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txt_mailAddress.Text = MailAddress;
            txt_body.Text = $"Sayın {Name} {Surname},";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
