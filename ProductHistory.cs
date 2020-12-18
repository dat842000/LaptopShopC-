using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCsharp.Views;
using ProjectCsharp.Models.Models;
using ProjectCsharp.Presenters;

namespace ProjectCsharp
{
    public partial class ProductHistory : UserControl, IHistoryView
    {
        private HistoryPresenter historyPresenter;
        private List<OrderModel> historyProducts;
        private int size;
        public ProductHistory(int height)
        {
            InitializeComponent();
            historyPresenter = new HistoryPresenter(this);
            historyPresenter.Display();
            size = height+1;
        }

        public List<OrderModel> ListHistory {
            set
            {
                historyProducts = value;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(this.Height == 75)
            {
                this.Height = 75*size;
            }
            else
            {
                this.Height = 75;
            }
        }
        public void OrderDetail(string url, string productname, string pending, string processing, string specs, string unitprice)
        {
            ProductHistoryDetailUC detail = new ProductHistoryDetailUC();
            detail.img.Image = new Bitmap(Application.StartupPath + "\\Images\\" + url);
            detail.lbl_productname.Text = productname;
            detail.pending.Image = new Bitmap(Application.StartupPath + "\\Images\\btnImg\\"+pending);
            detail.processing.Image = new Bitmap(Application.StartupPath + "\\Images\\btnImg\\" + processing);
            detail.lbl_specs.Text = specs;
            detail.lbl_unitprice.Text = unitprice;
            detail.Dock = DockStyle.Top;
            panel1.Controls.Add(detail);
        }
    }
}
