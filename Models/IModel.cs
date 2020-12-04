using ProjectCsharp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCsharp.Models
{
    public interface IModel
    {
        bool Login(string username, string password);
        UserProfileModel UserProfile();
        List<ProductModel> GetProducts();
        void SetCartProducts(List<OrderDetailModel> cartProduct);
        List<OrderDetailModel> GetCartProduct();
        void setOrder(List<OrderDetailModel> buyProducts);
        List<OrderDetailModel> getOrder();
        List<OrderModel> getHistory();
    }
}
