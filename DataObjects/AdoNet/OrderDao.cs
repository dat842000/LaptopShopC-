using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class OrderDao : IOrderDao
    {
        static Db db = new Db();

        public Order GetOrder(int OrderID)
        {

            string sql =
            @"SELECT OrderID, OrderDate, OrderStatus
              FROM [Order] 
             WHERE OrderID = @OrderID";

            object[] parms = { "@OrderID", OrderID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Order> GetOrdersByAccount(int AccountID)
        {
            string sql =
              @" SELECT OrderID, OrderDate, OrderStatus
                   FROM [Order]
                  WHERE AccountID = @AccountID
               ORDER BY OrderDate ASC";

            object[] parms = { "@AccountID", AccountID };
            return db.Read(sql, Make, parms).ToList();
        }

        static Func<IDataReader, Order> Make = reader =>
           new Order
           {
               OrderID = reader["OrderId"].AsId(),
               OrderDate = reader["OrderDate"].AsDateTime(),
               OrderStatus = reader["OrderStatus"].AsInt()
           };


        // creates query parameters list from Order object

        object[] Take(Order order)
        {
            return new object[]
            {
                "@OrderID", order.OrderID,
                "@OrderDate", order.OrderDate,
                "@OrderStatus", order.OrderStatus
            };
        }
    }
}
