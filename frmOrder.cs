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
            LoadOrder();
            TextChange();
        }

        public List<OrderDetailModel> OrderProducts
        {
            set
            {
                orderProducts = value;
            }
        }
        private void LoadOrder()
        {
            
            for (int i = 0; i < orderProducts.Count; i++)
            {
                guna2DataGridView2.Rows.Add(1);
                guna2DataGridView2.Rows[i].Cells[1].Value = Image.FromFile(@"Images\" + orderProducts.ElementAt(i).ImgUrl);
                guna2DataGridView2.Rows[i].Cells[2].Value = orderProducts.ElementAt(i).ProductName;
                if (orderProducts.ElementAt(i).OrderStatus.Equals("Pending"))
                {
                    guna2DataGridView2.Rows[i].Cells[3].Value = Image.FromFile(@"Images\btnImg\check.png");
                    guna2DataGridView2.Rows[i].Cells[4].Value = Image.FromFile(@"Images\btnImg\processing.png");
                }
                else
                {
                    guna2DataGridView2.Rows[i].Cells[4].Value = Image.FromFile(@"Images\btnImg\check.png");
                    guna2DataGridView2.Rows[i].Cells[3].Value = Image.FromFile(@"Images\btnImg\check.png");
                }
                guna2DataGridView2.Rows[i].Cells[5].Value = orderProducts.ElementAt(i).Specs.ToString();
                guna2DataGridView2.Rows[i].Cells[6].Value = orderProducts.ElementAt(i).UnitPrice.ToString() + " $";
                guna2DataGridView2.Rows[i].Cells[7].Value = orderProducts.ElementAt(i).Quantity.ToString();
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextChange();
        }
        public void TextChange()
        {
            int selectedRowIndex=0;
            Double total = 0;
            foreach(var p in orderProducts)
            {
                total += p.UnitPrice * p.Quantity;
            }
            if (orderProducts.Count > 0)
            {
                selectedRowIndex = guna2DataGridView2.CurrentCell.RowIndex;
                DateTime orderDate = orderProducts.ElementAt(selectedRowIndex).OrderDate;
                lb_orderDate.Text = orderDate.ToShortDateString();
                lb_ExpectedDate.Text = orderDate.AddDays(+3).ToShortDateString();
                lbl_Total.Text = total.ToString()+" $";
            }
        }
    }
}
