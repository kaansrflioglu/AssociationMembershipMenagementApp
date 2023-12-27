using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SendDebtMail : Form
    {
        //Alıcılar için bir dizi oluşturuyoruz.
        private List<string> recipients = new List<string>();

        public void UpdateRecipients(List<string> newRecipients)
        {
            recipients = newRecipients;
        }

        public SendDebtMail()
        {
            InitializeComponent();
        }

        private void SendDebtMail_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            //Varsayılan mesaj başlığı ve içeriğini tanımlıyoruz.
            txt_subject.Text = "Dernek Aidat Ödemeleriniz Hakkında Hatırlatma"; //Başlık
            txt_body.Text = "Hatırlatmak isteriz ki, henüz yapmadığınız aidat ödemeleriniz mevcut. " +
                            "Lütfen en kısa zamanda ödemeyi gerçekleştirin.\r\n\r\n" +
                            "Sorularınız için bize dernektakip453@gmail.com Email adresi üzerinden ulaşabilirsiniz.\r\n\r\n" +
                            "Teşekkür eder, ödemenizi bekleriz.\r\n\r\n" +
                            "Saygılarımızla,\r\nGenç Beşiktaşlılar Derneği."; //Gövde
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("dernektakip453@gmail.com", "mkyj fdic iueg cbbg");
                smtpClient.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dernektakip453@gmail.com");

                //Dizinin elemanlarını virgül ile ayırır böylece toplu maile hazır hale gelir.
                foreach (string recipient in recipients)
                {
                    mail.To.Add(recipient.Trim());
                }

                mail.Subject = txt_subject.Text;
                mail.Body = txt_body.Text;

                smtpClient.Send(mail);

                MessageBox.Show("E-postalar başarıyla gönderildi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}