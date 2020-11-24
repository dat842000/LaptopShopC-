﻿using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class ProductsPresenter : Presenter<IProductsView>
    {
        public ProductsPresenter(IProductsView view) : base(view)
        {
        }
        public void Display()
        {
            View.Products = Model.GetProducts();
        }
    }
}
