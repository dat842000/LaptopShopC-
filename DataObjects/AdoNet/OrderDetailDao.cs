using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class OrderDetailDao : IOrderDetailDao
    {
        static Db db = new Db();

        public List<OrderDetail> GetOrderDetails(int OrderID)
        {
            string sql =
            @"SELECT OrderID, O.ProductID, ProductName, O.UnitPrice
                FROM [OrderDetail] O JOIN [Product] P ON O.ProductID = P.ProductID 
               WHERE OrderID = @OrderID";

            object[] parms = { "@OrderID", OrderID };
            return db.Read(sql, Make, parms).ToList();
        }


        // creates order detail object from IDataReader

        static Func<IDataReader, OrderDetail> Make = reader =>
          new OrderDetail
          {
              OrderID = reader["OrderID"].AsId(),
              ProductID = reader["ProductID"].AsId(),
              ProductName = reader["ProductName"].AsString(),
              UnitPrice = reader["UnitPrice"].AsDouble(),
              Quantity = reader["Quantity"].AsInt()
          };


        // creates query parameter list from order detail object

        object[] Take(OrderDetail orderDetail)
        {
            return new object[]
            {
                "@OrderID", orderDetail.OrderID,
                "@ProductID", orderDetail.ProductID,
                "@ProductName", orderDetail.ProductName,
                "@UnitPrice", orderDetail.UnitPrice,
                "@Quantity", orderDetail.Quantity
            };
        }
    }
}
