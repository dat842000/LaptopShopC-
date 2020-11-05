using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class OrderDetail : BusinessObject
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public Order Order { get; set; }
    }
}
