using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TruckSystem.Utils;

namespace TruckSystem.Mail
{
    public class SmtpEmail
    {
        public List<string> receipts { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public bool body_is_html { get; set; }
        public List<string> attachments { get; set; }
        public static string email_from { get; set; }
        public static string password { get; set; }        
        public static int port { get; set; }
        public static string smtp_server { get; set; }
        public static bool SSL { get; set; }

        public SmtpEmail()
        {
            receipts = new List<string>();
            attachments = new List<string>();
        }
        public int SendMail()
        {
            if (String.IsNullOrEmpty(email_from)
                || String.IsNullOrEmpty(password)
                || String.IsNullOrEmpty(smtp_server)
                || (port == 0))
                throw new Exception("Informações do Host SMTP não foram informadas.");


            MailMessage msg = new MailMessage();
            if (receipts.Count == 0)
                throw new Exception("É necessário informar um email para envio.");
            else
                foreach (string s in receipts)
                    msg.To.Add(new MailAddress(s));
            
            msg.From = new MailAddress(email_from);
            msg.Subject = subject;
            msg.Body = body;
            msg.IsBodyHtml = body_is_html;
            if(attachments.Count > 0)
                foreach(string s in attachments)
                    msg.Attachments.Add(new Attachment(s));

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(email_from, password);
            client.Port = port;
            client.Host = smtp_server;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = SSL;
            try
            {
                client.Send(msg);
                return 0;
            }
            catch (Exception ex)
            {
                return 1;
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static void LoadCfg()
        {
            try
            {
                email_from = INI.ReadValue("SMTP", "User");
                password = Util.Decrypt(INI.ReadValue("SMTP", "Password"));
                port = Convert.ToInt32(INI.ReadValue("SMTP", "Port"));
                smtp_server = INI.ReadValue("SMTP", "Server");
                SSL = Convert.ToBoolean(INI.ReadValue("SMTP", "SSL"));
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao ler as informações do Host SMTP.", ex);
            }
        }
    }
}
