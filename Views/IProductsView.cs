﻿using ProjectCsharp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Views
{
    public interface IProductsView : IView
    {
        List<OrderDetailModel> CartProducts { get; set; }
        List<ProductModel> Products { set; }
    }
}
