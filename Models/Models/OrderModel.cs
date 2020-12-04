using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Models.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string OrderStatus { get; set; }
        public int Quantity { get; set; }

        public List<OrderDetailModel> OrderDetails { get; set; }
        public UserProfileModel User { get; set; }
    }
}
