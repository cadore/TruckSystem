using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem.FileManager.Utils
{
    public class UtilFiles
    {
        public static string FormatSize(long bytes)
        {
            if (bytes < 0) throw new ArgumentException("bytes");

            double h;
            string sufix;

            if (bytes >= 1152921504606846976L) // Exabyte (1024^6)
            {
                h = bytes >> 50;
                sufix = "EB";
            }
            else if (bytes >= 1125899906842624L) // Petabyte (1024^5)
            {
                h = bytes >> 40;
                sufix = "PB";
            }
            else if (bytes >= 1099511627776L) // Terabyte (1024^4)
            {
                h = bytes >> 30;
                sufix = "TB";
            }
            else if (bytes >= 1073741824) // Gigabyte (1024^3)
            {
                h = bytes >> 20;
                sufix = "GB";
            }
            else if (bytes >= 1048576) // Megabyte (1024^2)
            {
                h = bytes >> 10;
                sufix = "MB";
            }
            else if (bytes >= 1024) // Kilobyte (1024^1)
            {
                h = bytes;
                sufix = "KB";
            }
            else return bytes.ToString("0 B"); // Byte

            h /= 1024;
            return h.ToString("0.## ") + sufix;
        }
    }
}
