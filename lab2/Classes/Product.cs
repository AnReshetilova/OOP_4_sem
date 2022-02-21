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
    public class Product
    {
        public static List<Product> Products = new List<Product>();
        public string Name { get; set; }
        public int Number { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Storekeeper Storekeeper { get; set; }
        static readonly string path = "goods.json";

        public Product() { }
        public Product(string name, int number, int size, int weight, string type, int count, Manufacturer manufacturer, Storekeeper storekeeper)
        {
            Name = name;
            Number = number;
            Size = size;
            Weight = weight;
            Type = type;
            Count = count;
            Manufacturer = manufacturer;
            Storekeeper = storekeeper;
        }

        public static void Serialize()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(Products));
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
                        Products = (JsonConvert.DeserializeObject<List<Product>>(sr.ReadLine()));
                    }
                }
            }
            catch
            { }
        }

        public override string ToString()
        {
            return $"{Name} {Manufacturer.Organisation}";
        }
    }
}
