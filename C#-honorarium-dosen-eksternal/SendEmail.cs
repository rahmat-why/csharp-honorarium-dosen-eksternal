using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    internal class SendEmail
    {
        // SMTP server configuration
        string smtpHost = "smtp.gmail.com";
        int smtpPort = 587;
        string username = "rahmatwhy00@gmail.com";
        string password = "drqzryswhlsgflsl";

        string email, subject, body;

        public SendEmail(string email, string subject, string body)
        {
            this.email = email;
            this.subject = subject;
            this.body = body;
        }

        public void send(string nama_dosen)
        {
            // Create SMTP client
            SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(username, password);
            smtpClient.EnableSsl = true;

            try
            {
                // Create message and set sender, recipient, subject, and content
                MailMessage message = new MailMessage();
                message.From = new MailAddress(username);
                message.To.Add(new MailAddress(email));
                message.Subject = subject;
                message.Body = body;

                // Attach the PDF file
                string currentPath = Environment.CurrentDirectory;
                string[] splitPath = currentPath.Split(new string[] { "\\bin\\" }, StringSplitOptions.None);
                currentPath = splitPath[0];
                string pdfPath = currentPath + "\\" + nama_dosen + ".pdf";
                Attachment attachment = new Attachment(pdfPath);
                message.Attachments.Add(attachment);

                // Send the message
                smtpClient.Send(message);

                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email. Error: " + ex.Message);
            }
        }
    }
}
