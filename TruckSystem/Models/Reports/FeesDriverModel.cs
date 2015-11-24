using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem.Models.Reports
{
    public class FeesDriverModel
    {
        public string reference { get; set; }
        public string driver { get; set; }
        public string emission_at { get; set; }
        public string document_driver { get; set; }
        public string signature { get; set; }
        public List<FeesDriverList> feesList { get; set; }
    }
    public class FeesDriverList
    {
        public DateTime date { get; set; }
        public string driver { get; set; }
        public string freight_id { get; set; }
        public decimal value { get; set; }
    }
}
