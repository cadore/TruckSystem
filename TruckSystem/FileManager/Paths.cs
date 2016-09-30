using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSystem.Utils;

namespace TruckSystem.FileManager
{
    public class Paths
    {
        public static string raiz = @"";

        public static string files = @"\files";

        public static string business;
        public static string drivers;
        public static string trucks;
        public static string trailers;
        public static string customers;
        public static string bank_accounts;
        public static string mail;
        public static string backups;

        public static string PathPG;
        public static string PathBackupFile;

        public static void buildPaths()
        {
            if (String.IsNullOrEmpty(raiz))
                throw new Exception("Path raiz esta vazio!");

            if (!Directory.Exists(raiz))
                throw new Exception("Não foi possivel acessar o diretório raiz do sistema.");

            mail = raiz + files + @"\mail";
            business = raiz + files + @"\business";
            drivers = raiz + files + @"\drivers";
            trucks = raiz + files + @"\trucks";
            trailers = raiz + files + @"\trailers";
            customers = raiz + files + @"\customers";
            bank_accounts = raiz + files + @"\bank_accounts";
            backups = raiz + files + @"\backups";
            
            try
            {
                string[] directories = { business, drivers, trucks, trailers, customers, bank_accounts, backups };
                for (int i = 0; i < directories.Length; i++)
                {
                    if (!Directory.Exists(directories[i]))
                        Directory.CreateDirectory(directories[i]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public static void verifyPath(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
