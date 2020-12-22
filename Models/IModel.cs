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
        UserProfileModel GetUserProfile();
        List<ProductModel> GetProducts();
        void SetCartProducts(List<ProductModel> cartProduct);
        List<ProductModel> GetCartProduct();
        void setOrdering(List<OrderDetailModel> buyProducts);
        List<OrderDetailModel> getOrdering();
        List<OrderModel> getHistory();
        Boolean Register(string Username, string Password, string Fullname, string Phone, string Email, string Address, Boolean Gender, string urlImg);
        void Logout();
        List<ProductModel> getProductByBrand(int BrandID);
        List<ProductModel> searchText(string searchText);
    }
}
