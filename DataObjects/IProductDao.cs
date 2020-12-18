using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface IProductDao
    {
        // gets a list of products for a given category

        List<Product> GetProductsByBrand(int BrandID, string sortExpression);

        // performs a search for products given several criteria

        List<Product> SearchProducts(string productName, string sortExpression);

        // gets a specific product

        List<Product> GetProducts();
        Product GetProduct(int ProductID);
    }
}
