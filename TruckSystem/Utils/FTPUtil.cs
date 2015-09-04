/*using CadoreFTP;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ModelsCardManager.Utils
{
    public class FTPUtil
    {
        public string dirCredentialeds { get; private set; }
        public string dirCustomers { get; private set; }

        public FTPUtil()
        {
            try
            {
                dirCredentialeds = Util.Decrypt(INI.ReadValue("FTP", "dirCredentialeds"));
                dirCustomers = Util.Decrypt(INI.ReadValue("FTP", "dirCustomers"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message , ex.InnerException);
            }
        }

        private ftp connectFTP()
        {
            try
            {
                string host = Util.Decrypt(INI.ReadValue("FTP", "host"));
                string user = Util.Decrypt(INI.ReadValue("FTP", "user"));
                string password = Util.Decrypt(INI.ReadValue("FTP", "password"));
                ftp ftp = new ftp(host, user, password);
                return ftp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void upload(string remoteFile, FileStream localFile)
        {
            try
            {               
                connectFTP().upload(remoteFile, localFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void uploadImage(string remoteFile, Image image)
        {
            try
            {
                string file = Path.GetTempPath() + /*@"cadoretecnologia\cardmanager\images\*//*"imgtemp" 
                    + String.Format("{0:dd-MM-yyyy_HH-mm-ss}", DateTime.Now);
                image.Save(file, ImageFormat.Jpeg);
                FileStream fsm = new FileStream(file, FileMode.Open);
                connectFTP().upload(remoteFile, fsm);
                fsm.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void download(string remoteFile, string localFile)
        {
            try
            {
                connectFTP().download(remoteFile, localFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public MemoryStream download(string remoteFile)
        {
            try
            {
                return connectFTP().download(remoteFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
*/