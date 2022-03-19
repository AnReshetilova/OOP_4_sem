using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.Classes;

namespace lab2.Builder
{
    interface IProductBuilder
    {
        public void SetName(string name);
        public void SetParam(int number, int size, int weight, string type, int count);
        public void SetManufacturer(Manufacturer manufacturer);
        public void SetManufacturer(string organisation, string country, string address, string phone);
        public void SetStorekeeper(Storekeeper storekeeper);
        public void SetStorekeeper(string name, int experience, string address);
        public Product Build();
    }
}
