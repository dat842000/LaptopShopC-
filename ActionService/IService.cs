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
        List<Brand> GetBrands();
        Brand GetBrandByProduct(int ProductID);

        Product GetProduct(int ProductID);
        List<Product> GetProductsByBrand(int BrandID, string sortExpression);
        List<Product> SearchProducts(string productName, string sortExpression);

        List<Account> GetAccounts(string sortExpression);
        Account GetAccountByOrder(int OrderID);
        List<Account> GetAccountsWithOrderStatistics(string sortExpression);
        void InsertAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(Account account);


        Order GetOrder(int OrderID);
        List<Order> GetOrdersByAccount(int AccountID);
        List<OrderDetail> GetOrderDetails(int OrderID);

    }
}
