using ProjectCsharp.Models.Models;
using ProjectCsharp.Presenters;
using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCsharp
{
    public partial class frmOrder : Form, IOrderView
    {
        private OrderPresenter orderPresenter;
        private List<OrderDetailModel> orderProducts;
        public frmOrder()
        {
            InitializeComponent();
            orderPresenter = new OrderPresenter(this);
            orderPresenter.Display();
            LoadListView();
        }

        public List<OrderDetailModel> OrderProducts 
        {
            set 
            {
                orderProducts = value;
            }
        }
        private void LoadListView()
        {
            for (int i = 0; i < orderProducts.Count; i++)
            {
                ListViewItem Product = new ListViewItem();
                Product.Text = orderProducts.ElementAt(i).ProductName;
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = orderProducts.ElementAt(i).UnitPrice.ToString() + " $" });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = orderProducts.ElementAt(i).Specs.ToString() });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = orderProducts.ElementAt(i).OrderDate.ToShortDateString() });
                
                lsvShow.Items.Add(Product);
            }
        }
    }
}
