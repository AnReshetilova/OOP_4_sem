using lab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.Classes;

namespace lab2.AbstractFactory
{
    class SimpleProjectFactory: AbstractFactory //единственная дочерняя фабрика, тк у нас производитель и кладовщик только одного типа
    {
        public override IManufacturer CreateManufacturer(string organisation, string country, string address, string phone)
        {
            return new Manufacturer(organisation, country, address, phone);
        }

        public override IStorekeeper CreateStorekeeper(string name, int experience, string address)
        {
            return new Storekeeper(name, experience, address);
        }
    }
}
