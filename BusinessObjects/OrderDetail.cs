using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class OrderDetail : BusinessObject
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImgUrl { get; set; }
        public String Specs { get; set; }
        public string OrderStatus { get; set; }
        public Order Order { get; set; }
    }
}
