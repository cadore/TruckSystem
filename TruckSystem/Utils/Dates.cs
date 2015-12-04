using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem.Utils
{
    public class Dates
    {
        public static DateTime getUTCDateTime()
        {
            try
            {
                //default Windows time server
                const string ntpServer = "c.ntp.br";

                // NTP message size - 16 bytes of the digest (RFC 2030)
                var ntpData = new byte[48];

                //Setting the Leap Indicator, Version Number and Mode values
                ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();

                //Offset to get to the "Transmit Timestamp" field (time at which the reply 
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

                return networkDateTime.ToLocalTime();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
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

        public static String GetWeekOfMonthExtensive(DateTime date)
        {
            string s = "";
            int n = GetWeekOfMonth(date);
            switch (n)
            {
                case 1:
                    s = "Primeira";
                    break;
                case 2:
                    s = "Segunda";
                    break;
                case 3:
                    s = "Terceira";
                    break;
                case 4:
                    s = "Quarta";
                    break;
                case 5:
                    s = "Quinta";
                    break;
                case 6:
                    s = "Sexta";
                    break;
            }
            return s;
        }

        public static int GetWeekOfMonth(DateTime date)
        {
            DateTime beginningOfMonth = new DateTime(date.Year, date.Month, 1);
            while (date.Date.AddDays(1).DayOfWeek != System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                date = date.AddDays(1);
            return (int)Math.Truncate((double)date.Subtract(beginningOfMonth).TotalDays / 7f) + 1;
        }

        public static DateTime GetDateStartWeek(DateTime date, int p = 0)
        {
            DateTime dateStart = date.AddDays(p - date.DayOfWeek.GetHashCode());
            return dateStart;
        }

        public static DateTime GetDateEndWeek(DateTime date, int p = 6)
        {
            DateTime dateEnd = date.AddDays(p - date.DayOfWeek.GetHashCode());
            return dateEnd;
        }

        /*
        public static String GetMonthOfNumber(int month)
        {
            string month_ext = "";

            switch (month)
            {
                case 1 | 01:
                    month_ext = "Janeiro";
                    break;
            }

            return month_ext;
        }
        */
    }
}
