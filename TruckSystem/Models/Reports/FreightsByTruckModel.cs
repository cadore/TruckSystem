using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem.Models.Reports
{
    public class FreightsByTruckModel
    {
        public string reference { get; set; }
        public string signature { get; set; }
        public string truck { get; set; }
        public string driver { get; set; }
        public string emission_at { get; set; }
        public decimal gross { get; set; }
        public List<ListFreights> listFreights { get; set; }
    }

    public class ListFreights
    {
        public long id { get; set; }
        public DateTime date { get; set; }
        public string product { get; set; }
        public decimal gross { get; set; }
        public decimal value_ton { get; set; }
        public decimal outputs { get; set; }
        public decimal fueleds { get; set; }
        public decimal liquid { get; set; }
        public string driver { get; set; }
        public decimal comission { get; set; }
        public List<ListOutputs> listOutputs { get; set; }
        public List<ListFueleds> listFueleds { get; set; }
    }
    public class ListOutputs
    {
        public DateTime date { get; set; }
        public string customer { get; set; }
        public string description { get; set; }
        public decimal value { get; set; }
    }
    public class ListFueleds
    {
        public DateTime date { get; set; }
        public string gas_station { get; set; }
        public decimal liters { get; set; }
        public decimal value_liters { get; set; }
        public decimal discont { get; set; }
        public decimal value_total { get; set; }
    }
}
