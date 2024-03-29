﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order : BusinessObject
    {
        public int OrderID { get; set; }
        public int AccountID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string OrderStatus { get; set; }
        public int Quantity { get; set; }
        public Account Account { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
