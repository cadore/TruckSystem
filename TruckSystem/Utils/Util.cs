using SecureApp;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TruckSystem.Utils
{
    public class Util
    {
        public static string Decrypt(String s)
        {
            return new DTICrypto().Decifrar(s, "wjm");
        }

        public static string Encrypt(String s)
        {
            return new DTICrypto().Cifrar(s, "wjm");
        }

        public static string RemoveSpecialCharacters(string text)
        {
            return Regex.Replace(text, "[^0-9a-zA-Z]+?", "");
        }
        public static int CalculateAge(DateTime source, DateTime birthday)
        {
            int anos = source.Year - birthday.Year;
            if (source.Month < birthday.Month 
                || (source.Month == birthday.Month 
                && source.Day < birthday.Day))
                anos--;
            return anos;
        }


        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool isConnectedWeb()
        {
            try
            {
                int Description;
                return InternetGetConnectedState(out Description, 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static string getInternalIp()
        {
            string _return = "";
            try
            {
                IPHostEntry ipEntry = Dns.GetHostByName(Environment.MachineName);
                IPAddress[] addr = ipEntry.AddressList;
                _return = addr[0].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return _return;
        }

        public static string getExternalIp()
        {
            if (isConnectedWeb())
            {
                try
                {
                    WebClient t = new WebClient();
                    string meuip = t.DownloadString("http://meuip.net.br/");
                    return meuip
                        .Substring(
                        meuip.IndexOf("o Meu IP? ") + "o Meu IP? ".Length,
                        meuip.IndexOf("</title>") - meuip.IndexOf("o Meu IP? ")
                        - "o Meu IP? ".Length);
                }
                catch(Exception)
                {
                    return "null";
                }
            }
            else
                return "null";
        }
    }
}
