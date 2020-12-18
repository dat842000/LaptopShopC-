using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface IOrderDao
    {
        Order GetOrder(int OrderID);
        void InsertOrder(Order order);

        List<Order> GetOrdersByAccount(int AccountID);
    }
}
