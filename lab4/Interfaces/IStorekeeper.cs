using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Interfaces
{
    public interface IStorekeeper
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Address { get; set; }

        public IStorekeeper Clone();
    }
}
