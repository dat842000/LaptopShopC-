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
        public frmHistory()
        {
            InitializeComponent();
            historyPresenter = new HistoryPresenter(this);
            historyPresenter.Display();
            displayProduct();
        }

        public List<OrderModel> ListHistory 
        {
            set
            {
                historyProducts = value;
            }
        }
        private void displayProduct()
        {
            for (int i = historyProducts.Count-1; i >= 0; i--)
            {
                List<OrderDetailModel> listOrderDetail = historyProducts.ElementAt(i).OrderDetails;
                ProductHistory ph = new ProductHistory(listOrderDetail.Count);
                ph.lbl_ID.Text = historyProducts.ElementAt(i).OrderID.ToString();
                ph.lbl_orderdate.Text = historyProducts.ElementAt(i).OrderDate.ToShortDateString();
                if (!historyProducts.ElementAt(i).ShippedDate.ToString().Equals("1/1/0001 12:00:00 AM"))
                {
                    ph.lbl_shippeddate.Text = historyProducts.ElementAt(i).ShippedDate.ToString();
                }
                else
                {
                    ph.lbl_shippeddate.Text = "";
                }
                ph.lbl_quantity.Text = historyProducts.ElementAt(i).Quantity.ToString();
                ph.lbl_status.Text = historyProducts.ElementAt(i).OrderStatus;
                for (int j = 0; j < listOrderDetail.Count; j++)
                {
                    if (listOrderDetail.ElementAt(j).OrderStatus.Equals("Pending"))
                    {
                        ph.OrderDetail(listOrderDetail.ElementAt(j).ImgUrl, listOrderDetail.ElementAt(j).ProductName, "check.png", "processing.png", listOrderDetail.ElementAt(j).UnitPrice.ToString(), listOrderDetail.ElementAt(j).Specs.ToString());
                    }
                    else
                    {
                        ph.OrderDetail(listOrderDetail.ElementAt(j).ImgUrl, listOrderDetail.ElementAt(j).ProductName, "check.png", "check.png", listOrderDetail.ElementAt(j).UnitPrice.ToString(), listOrderDetail.ElementAt(j).Specs.ToString());
                    }
                }
                ph.Dock = DockStyle.Top;
                panel2.Controls.Add(ph);
            }
        }
    }
}
