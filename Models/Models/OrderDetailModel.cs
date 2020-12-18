using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Models.Models
{
    public class OrderDetailModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Double UnitPrice { get; set; }
        public string ImgUrl { get; set; }
        public String Specs { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int Quantity { get; set; }
        public OrderModel Order { get; set; }
    }
}
