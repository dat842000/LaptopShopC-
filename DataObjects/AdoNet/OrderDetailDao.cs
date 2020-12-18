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
            @"SELECT OrderID, O.ProductID, P.ProductName, O.UnitPrice, O.Specs, OrderStatus, O.Quantity, O.ImgUrl  
                FROM [OrderDetail]  O JOIN Product P ON O.ProductId = P.ProductId
               WHERE OrderID = @OrderID";

            object[] parms = { "@OrderID", OrderID };
            return db.Read(sql, Make, parms).ToList();
        }
        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            string sql =
           @"INSERT INTO [OrderDetail] (OrderID, ProductID, UnitPrice, ImgUrl, Specs, Quantity, OrderStatus) 			
              VALUES (@OrderID, @ProductID, @UnitPrice, @ImgUrl, @Specs, @Quantity, @OrderStatus)";

            db.Insert(sql, Take(orderDetail));
        }


        // creates order detail object from IDataReader

        static Func<IDataReader, OrderDetail> Make = reader =>
          new OrderDetail
          {
              OrderID = reader["OrderID"].AsId(),
              ProductID = reader["ProductID"].AsId(),
              ProductName = reader["ProductName"].AsString(),
              UnitPrice = reader["UnitPrice"].AsDouble(),
              ImgUrl = reader["ImgUrl"].AsString(),
              Specs = reader["Specs"].AsString(),
              OrderStatus = reader["OrderStatus"].AsString(),
              Quantity = reader["Quantity"].AsInt()
          };


        // creates query parameter list from order detail object

        object[] Take(OrderDetail orderDetail)
        {
            return new object[]
            {
                "@OrderID", orderDetail.OrderID,
                "@ProductID", orderDetail.ProductID,
                "@UnitPrice", orderDetail.UnitPrice,
                "@Quantity", orderDetail.Quantity,
                "@ImgUrl",orderDetail.ImgUrl,
                "@OrderStatus",orderDetail.OrderStatus,
                "@Specs",orderDetail.Specs
            };
        }
    }
}
