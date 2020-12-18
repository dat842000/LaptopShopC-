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
    public partial class Laptop : UserControl
    {
        public Form MyForm { get; set; }
        string url;
        string laptopName;
        string unitPrice;
        float ratingPoint;
        public event EventHandler UserControlButtonClicked;
        public Laptop()
        {
            InitializeComponent();
            guna2ShadowPanel2.Click += Click1;
            gunaPictureBox2.Click += Click1;
            gunaLabel2.Click += Click1;
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
                gunaLabel2.Text = value; 
            }
        }
        public string urlImg
        {
            get { return url; }
            set
            {
                gunaPictureBox2.Image = new Bitmap(Application.StartupPath +"\\Images\\"+ value);
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
                gunaLabel3.Text = value + " $";
            }
        }
        public Double rating
        {
            get
            {
                return(Double) ratingPoint;
            }
            set
            {
                ratingPoint =  (float) value;
                guna2RatingStar1.Value = (float) value;
            }
        }

        private void gunaPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel2.FillColor = Color.LightBlue;
            
        }

        private void gunaPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel2.FillColor = Color.WhiteSmoke;
        }
    }
}
