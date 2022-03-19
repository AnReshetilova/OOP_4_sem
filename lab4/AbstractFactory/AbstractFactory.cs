using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.Interfaces;

namespace lab2.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IManufacturer CreateManufacturer(string organisation, string country, string address, string phone);
        public abstract IStorekeeper CreateStorekeeper(string name, int experience, string address);
    }
}
