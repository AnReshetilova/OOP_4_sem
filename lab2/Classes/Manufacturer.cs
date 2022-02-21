using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace lab2.Classes
{
    [Serializable]
    public class Manufacturer
    {
        public static List<Manufacturer> Manufacturers = new List<Manufacturer>();
        public string Organisation { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public static readonly string path = "manufacturers.json";

        public Manufacturer(string organisation, string country, string address, string phone)
        {
            Organisation = organisation;
            Country = country;
            Address = address;
            Phone = phone;
        }

        public Manufacturer() { }
        public static Manufacturer FindManufacturer(string info)
        {
            (string org, string country) manufacturerInfo;
            manufacturerInfo.org = info.Split(' ')[0];
            manufacturerInfo.country = info.Split(' ')[1];
            return Manufacturers.Where(e => e.Organisation == manufacturerInfo.org && e.Country == manufacturerInfo.country).First();
        }

        public static void Serialize()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(Manufacturers));
            }
        }

        public static void Deserialize()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Manufacturers = (JsonConvert.DeserializeObject<List<Manufacturer>>(sr.ReadLine()));
                    }
                }
            }
            catch { }
        }


        public override string ToString()
        {
            return $"{Organisation} {Country}";
        }
    }

}

