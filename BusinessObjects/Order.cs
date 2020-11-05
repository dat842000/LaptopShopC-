using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order : BusinessObject
    {
        public int OrderID { get; set; }
        public Product  Product { get; set; }//ProductID
        public DateTime OrderDate { get; set; }
        public int orderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
