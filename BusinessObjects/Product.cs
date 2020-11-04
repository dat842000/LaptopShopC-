﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product: BusinessObject
    {
        public int ProductID { get; set; }
        public int BrandID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Specs { get; set; }
    }
}