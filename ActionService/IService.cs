using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService
{
    public interface IService
    {
        //List<Brand> GetBrands();

        List<Product> GetProducts();
        //List<Product> GetProductsByBrand(int BrandID, string sortExpression);
        //List<Product> SearchProducts(string productName, string sortExpression);

        Account GetAccount(string Username, string Password);

        //void UpdateAccount(Account account);
        void InsertAccount(Account account);
        Account CheckUserNameDuplicate(string Username);

        List<Order> GetOrdersByAccount(int AccountID);
        void InsertOrder(Order order);
        List<OrderDetail> GetOrderDetails(int OrderID);
        void InsertOrderDetail(OrderDetail orderDetail);

    }
}
