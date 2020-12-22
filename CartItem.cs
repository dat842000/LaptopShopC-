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
        int quantity;
        public event EventHandler UserControlButtonClicked;
        public event EventHandler changQuantity;
        public CartItem()
        {
            InitializeComponent();
            btn_Delete.Click += Delete_Click;
            gunaNumeric.Click += changeValue;

        }
        public void Delete_Click(object obj, EventArgs ea)
        {
            UserControlButtonClicked(this, EventArgs.Empty);
        }
        public void changeValue(object obj, EventArgs ea)
        {
            quantity =(int) gunaNumeric.Value;
            changQuantity(this, EventArgs.Empty);
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
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                gunaNumeric.Value = value;
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
