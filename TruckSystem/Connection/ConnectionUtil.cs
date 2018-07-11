﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSystem.Utils;

namespace TruckSystem.Connection
{
    public class ConnectionUtil
    {
        public static string Host { get; private set; }
        public static string Port { get; private set; }
        public static string DataBase { get; private set; }
        public static string User { get; private set; }
        public static string Password { get; private set; }

        public static string ConnectionString { get; private set; }
        
        public ConnectionUtil()
        {
            try
            {
                Host = Util.Decrypt(INI.ReadValue("CONNECTION", "host"));
                Port = Util.Decrypt(INI.ReadValue("CONNECTION", "port"));
                DataBase = Util.Decrypt(INI.ReadValue("CONNECTION", "db"));
                User = Util.Decrypt(INI.ReadValue("CONNECTION", "user"));
                Password = Util.Decrypt(INI.ReadValue("CONNECTION", "password"));

                ConnectionString = String.Format("Server={0};Port={1};User id={2};password={3};Database={4};",
                Host, Port, User, Password, DataBase);
            }
            catch (Exception ex)
            {
                ConnectionString = null;
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}