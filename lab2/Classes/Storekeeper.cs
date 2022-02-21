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
    public class Storekeeper
    {
        public static List<Storekeeper> Storekeepers = new List<Storekeeper>();
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Address { get; set; }
        static readonly string path = "storekeepers.json";
        public Storekeeper() { }
        public Storekeeper(string name, int experience, string address)
        {
            Name = name;
            Experience = experience;
            Address = address;
        }

        public static Storekeeper FindStorekeeper(string info)
        {
            (string name, string address) storekeeperInfo;
            storekeeperInfo.name = info.Split(' ')[0];
            storekeeperInfo.address = info.Split(' ')[1];
            return Storekeepers.Where(e => e.Name == storekeeperInfo.name && e.Address == storekeeperInfo.address).First();
        }

        public static void Serialize()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(Storekeepers));
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
                        Storekeepers = (JsonConvert.DeserializeObject<List<Storekeeper>>(sr.ReadLine()));
                    }
                }
            }
            catch { }
        }

        public override string ToString()
        {
            return $"{Name} {Address}";
        }
    }
}
