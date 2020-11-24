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
        List<ProductModel> GetProducts();
    }
}
