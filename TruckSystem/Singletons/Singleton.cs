using System;

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
    }
}
