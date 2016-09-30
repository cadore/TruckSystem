using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TruckSystem.FileManager;
using TruckSystem.Utils;

namespace TruckSystem.Mail
{
    public class SmtpMailUtil
    {
        public List<string> receipts { get; set; }
        public List<string> receipts_cc { get; set; }
        public List<string> receipts_bcc { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public List<string> attachments { get; set; }
        public static string email_from { get; set; }
        public static string password { get; set; }        
        public static int port { get; set; }
        public static string smtp_server { get; set; }
        public static bool SSL { get; set; }
        public static string signature { get; set; }

        public SmtpMailUtil()
        {
            receipts = new List<string>();
            receipts_cc = new List<string>();
            receipts_bcc = new List<string>();
            attachments = new List<string>();
        }
        public int SendMail()
        {
            if (String.IsNullOrEmpty(email_from)
                || String.IsNullOrEmpty(password)
                || String.IsNullOrEmpty(smtp_server)
                || (port == 0))
                throw new Exception("Informações do Host SMTP não foram informadas.");
            Console.WriteLine("Tudo OK");

            MailMessage msg = new MailMessage();
            if (receipts.Count == 0)
                throw new Exception("É necessário informar um email para envio.");
            else
                foreach (string s in receipts)
                    msg.To.Add(new MailAddress(s));
            if (receipts_cc.Count > 0)
                foreach (string s in receipts_cc)
                    msg.CC.Add(new MailAddress(s));
            if (receipts_bcc.Count > 0)
                foreach (string s in receipts_bcc)
                    msg.Bcc.Add(new MailAddress(s));
            
            msg.From = new MailAddress(email_from);
            msg.Subject = subject;
            msg.Body = "<HTML><BODY>" + body;
            if (!String.IsNullOrEmpty(signature)){
                signature = signature.Replace("localimage:", Paths.mail + @"\");
                msg.Body += "<br/><br/><label>---</label><br/>" + signature + "</BODY></HTML>";
            }                
            else
                msg.Body += "</BODY></HTML>";
            msg.IsBodyHtml = true;
            if(attachments.Count > 0)
                foreach(string s in attachments)
                    msg.Attachments.Add(new Attachment(s));
            Console.WriteLine("Tudo indexado");
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(email_from, Util.Decrypt(password));
            client.Port = port;
            client.Host = smtp_server;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = SSL;
            Console.WriteLine("Iniciando o Envio");
            //try
            //{
                client.Send(msg);
                Console.WriteLine(msg.Body);
                Console.WriteLine("Enviado");
                return 0;
            /*}
            catch (Exception ex)
            {                
                throw new Exception(ex.Message, ex.InnerException);
                return 1;
            }*/
        }

        public static void LoadCfg()
        {
            try
            {
                mails sm = mails.SingleOrDefault(1);
                if (sm == null)
                    return;
                email_from = sm.user;
                password = sm.password;
                port = sm.port;
                smtp_server = sm.smtp_server;
                SSL = sm.ssl;
                signature = sm.signature;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao ler as informações do Host SMTP.", ex);
            }
        }
    }
}
