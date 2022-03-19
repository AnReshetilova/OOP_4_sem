using lab2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Builder
{
    class FullProductBuilder : IProductBuilder
    {
        string name;
        int number;
        int size;
        int weight;
        string type;
        int count;
        Manufacturer manufacturer;
        Storekeeper storekeeper;

        public FullProductBuilder()
        {
            name = "-";
            number = 0;
            size = 0;
            weight = 0;
            type = "-";
            count = 0;
            manufacturer = null;
            storekeeper = null;
        }
        public Product Build()
        {
            Product product = new Product(name, number, size, weight, type, count, manufacturer, storekeeper);
            return product;
        }

        public void SetManufacturer(string organisation, string country, string address, string phone)
        {
            manufacturer = new Manufacturer(organisation, country, address, phone);
        }

        public void SetManufacturer(Manufacturer manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetParam(int number, int size, int weight, string type, int count)
        {
            this.number = number;
            this.size = size;
            this.weight = weight;
            this.type = type;
            this.count = count;
        }

        public void SetStorekeeper(Storekeeper storekeeper)
        {
            this.storekeeper = storekeeper;
        }

        public void SetStorekeeper(string name, int experience, string address)
        {
            storekeeper = new Storekeeper(name, experience, address);
        }
    }
}
