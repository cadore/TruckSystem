using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TruckSystem
{
    public class jsontest
    {
        public void run()
        {
            String mark_url = @"http://fipeapi.appspot.com/api/1/carros/marcas.json";
            string mark_json = new WebClient().DownloadString(mark_url);
            JArray mark_results = JArray.Parse(mark_json);
            Console.WriteLine("Total Marks: " + mark_results.Count);
            Console.WriteLine();
            for (int i = 0; i < mark_results.Count; i++)
            {
                string mark_key = (string)mark_results[i]["key"];
                string mark_id = (string)mark_results[i]["id"];
                string mark_fipe_name = (string)mark_results[i]["fipe_name"];
                string mark_name = (string)mark_results[i]["name"];
                Console.WriteLine(" Name: {0}, Fipe Name: {1}, Key: {2}, ID: {3}", mark_name, mark_fipe_name, mark_key, mark_id);

                string veh_url = @"http://fipeapi.appspot.com/api/1/carros/veiculos/" + mark_id + ".json";
                string veh_json = new WebClient().DownloadString(veh_url);
                JArray veh_results = JArray.Parse(veh_json);
                Console.WriteLine("  Total Vehicles: " + veh_results.Count);
                for (int i2 = 0; i2 < veh_results.Count; i2++ )
                {
                    string veh_key = (string)veh_results[i2]["key"];
                    string veh_id = (string)veh_results[i2]["id"];
                    string veh_fipe_name = (string)veh_results[i2]["fipe_name"];
                    string veh_name = (string)veh_results[i2]["name"];
                    Console.WriteLine("   Name: {0}, Fipe Name: {1}, Key: {2}, ID: {3}", veh_name, veh_fipe_name, veh_key, veh_id);
                }
                Console.WriteLine();
            }
        }
   }
}