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
    public partial class Nofitication : Form
    {
        public Nofitication(string message)
        {
            InitializeComponent();
            switch (message)
            {
                case "Select an item":
                    this.BackColor = Color.FromArgb(249, 118, 176);
                    iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
                    lb_message.Text = message;
                    break;
                case "Login required":
                    this.BackColor = Color.MediumSeaGreen;
                    iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
                    lb_message.Text = message;
                    break;
                case "Login failed":
                    this.BackColor = Color.Crimson;
                    iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    lb_message.Text = message;
                    break;
                case "Login Success":
                    this.BackColor = Color.LightSkyBlue;
                    iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    lb_message.Text = message;
                    break;
                case "Register Success":
                    this.BackColor = Color.LightSkyBlue;
                    iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    lb_message.Text = message;
                    break;
                case "Register failed":
                    this.BackColor = Color.Crimson;
                    iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    lb_message.Text = message;
                    break;
            }
        }

        private void Nofitication_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
