using System;
using System.Collections.Generic;
namespace TruckSystem.Utils
{
    public class Money
    {
        public static List<decimal> Parcel(decimal value, int qntParcel, int qntDecimal = 2)
        {
            List<decimal> d = new List<decimal>();
            if (value == 0 || qntParcel == 0)
                return null;
            decimal pow = (decimal)Math.Pow(10, qntDecimal);
            decimal valueParcels = Math.Truncate(value / qntParcel * pow) / pow;
            decimal valueLastParcel = value - (valueParcels * (qntParcel - 1));
            for (int i = 0; i < (qntParcel - 1); i++)
            {
                d.Add(valueParcels);
            }
            d.Add(valueLastParcel);
            return d;
        }
    }
}
