using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjektB
{
    class MailMonkey
    {
        public static void SendMail()
        {
            using (SmtpClient client = new SmtpClient(ConfigurationManager.AppSettings["smtpServer"]))
            {
                using (MailMessage mail = new MailMessage(ConfigurationManager.AppSettings["sSender"], ConfigurationManager.AppSettings["addressTo"]))
                {
                    Attachment att = new Attachment(AppDomain.CurrentDomain.BaseDirectory + "weather.png");

                    mail.Subject = ConfigurationManager.AppSettings["eSubject"];

                    StringBuilder body = new StringBuilder();

                    body.AppendLine(ConfigurationManager.AppSettings["eBodyLine1"]);
                    body.AppendLine(ConfigurationManager.AppSettings["eBodyLine2"]);

                    mail.Body = body.ToString();
                    mail.Attachments.Add(att);

                    client.Send(mail);
                }
            }
        }
    }
}
