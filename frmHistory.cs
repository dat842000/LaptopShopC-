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
    public partial class frmHistory : Form, IHistoryView
    {
        private HistoryPresenter historyPresenter;
        private List<OrderModel> historyProducts;
        private string SelectedItem;
        public frmHistory()
        {
            InitializeComponent();
            historyPresenter = new HistoryPresenter(this);
            historyPresenter.Display();
            LoadOrderListView();
        }

        public List<OrderModel> ListHistory 
        {
            set
            {
                historyProducts = value;
            }
        }
        private void LoadOrderListView()
        {
            for (int i = 0; i < historyProducts.Count; i++)
            {
                ListViewItem Product = new ListViewItem();
                Product.Text = historyProducts.ElementAt(i).OrderID.ToString();
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = historyProducts.ElementAt(i).OrderDate.ToShortDateString() });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = historyProducts.ElementAt(i).ShippedDate.ToString() });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = historyProducts.ElementAt(i).Quantity.ToString() });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = historyProducts.ElementAt(i).OrderStatus });
                lsvOrder.Items.Add(Product);
            }
        }
        private void LoadOrderDetail()
        {
            for (int i = 0; i < historyProducts.Count; i++)
            {
                if (historyProducts.ElementAt(i).OrderID.ToString().Equals(SelectedItem))
                {
                    List<OrderDetailModel> listOrderDetail = historyProducts.ElementAt(i).OrderDetails;
                    for (int j = 0; j < listOrderDetail.Count; j++)
                    {
                        ListViewItem Product = new ListViewItem();
                        Product.Text = listOrderDetail.ElementAt(j).ProductName;
                        Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listOrderDetail.ElementAt(j).UnitPrice.ToString() + " $" });
                        Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listOrderDetail.ElementAt(j).Specs.ToString() });
                        lsvOrderDetail.Items.Add(Product);
                    }
                }
            }
        }
        private void lsvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            SelectedItem = "";
            if (lsv.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv.SelectedItems[0];
                SelectedItem = item.Text;
            }
            lsvOrderDetail.Items.Clear();
            LoadOrderDetail();
        }
    }
}
