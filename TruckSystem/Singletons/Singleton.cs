using System;
using System.Windows.Forms;
using TruckSystem.UI.Utils;

namespace TruckSystem
{
    public static class Singleton
    {
        private static user us = null;

        public static  void setUser(user u)
        {
            us = u;
        }

        public static  user getUser()
        {
            return us;
        }

        public static bool autenticateUser()
        {
            return auth(false);
        }

        public static bool autenticateAdmin()
        {
            return auth(true);
        }

        private static bool auth(bool p)
        {
            bool f = false;
            AuthenticateForm af = new AuthenticateForm(true);
            DialogResult rs = af.ShowDialog();
            if (rs != DialogResult.OK && !af.Authenticate)
                f = false;
            else
                f = true;
            return f;
        }
    }
}
