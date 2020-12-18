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
        public Order GetOrder(int orderId)
        {

            string sql =
            @"SELECT OrderID, AccountID, OrderDate, ShippedDate, OrderStatus, Quantity
              FROM [Order] 
             WHERE OrderId = @OrderId";

            object[] parms = { "@OrderId", orderId };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }
        public void InsertOrder(Order order)
        {
            string sql =
            @"INSERT INTO [Order] (AccountID, OrderDate, ShippedDate, OrderStatus, Quantity) 			
              VALUES (@AccountID, @OrderDate, @ShippedDate, @OrderStatus, @Quantity)";

                order.OrderID = db.InsertIdentity(sql, Take(order));
        }
        public List<Order> GetOrdersByAccount(int AccountID)
        {
            string sql =
              @" SELECT OrderID, AccountID, OrderDate, ShippedDate, OrderStatus, Quantity
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
               ShippedDate = reader["ShippedDate"].AsDateTime(),
               OrderStatus = reader["OrderStatus"].AsString(),
               Quantity = reader["Quantity"].AsInt(),
           };


        // creates query parameters list from Order object

        object[] Take(Order order)
        {
            return new object[]
            {
                "@OrderID", order.OrderID,
                "@AccountID", order.AccountID,
                "@OrderDate", order.OrderDate,
                "@ShippedDate",order.ShippedDate,
                "@OrderStatus", order.OrderStatus,
                "@Quantity",order.Quantity
            };
        }
    }
}
