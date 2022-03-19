﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Interfaces
{
    public interface IManufacturer
    {
        public string Organisation { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
