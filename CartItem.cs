using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCsharp
{
    public partial class CartItem : UserControl
    {
        public Form MyForm { get; set; }
        string url;
        string laptopName;
        string unitPrice;
        public event EventHandler UserControlButtonClicked;
        public CartItem()
        {
            InitializeComponent();
            btn_Delete.Click += Click1;
        }
        public void Click1(object obj, EventArgs ea)
        {
            UserControlButtonClicked(this, EventArgs.Empty);
        }
        public string name
        {
            get { return laptopName; }
            set
            {
                laptopName = value;
                gunaLabel1.Text = value;
            }
        }
        public string urlImg
        {
            get { return url; }
            set
            {
                gunaPictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + value);
                url = value;
            }
        }
        public string unitprice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
                gunaLabel2.Text = value + " $";
            }
        }

        private void gunaPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel1.FillColor = Color.LightBlue;
        }

        private void gunaPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel1.FillColor = Color.GhostWhite;
        }

        private void btn_Delete_MouseEnter(object sender, EventArgs e)
        {
            btn_Delete.ForeColor = Color.FromArgb(91, 164, 198);
        }

        private void btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.ForeColor = Color.Gray;
        }
    }
}
