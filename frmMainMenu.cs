using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCsharp
{
    public partial class frmMainMenu : Form
    {
        private IconButton currentBtn;
        private Color lastColorBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
           OpenChildForm(new frmShop(false));


            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
            public static Color color5 = Color.MediumSeaGreen;
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.GhostWhite;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.Visible = true;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = lastColorBtn;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = lastColorBtn;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            lblTitleChildForm.ForeColor = lastColorBtn;
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            Boolean Status = false;
            if(status == LoginStatus.LoggedIn)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
            ActivateButton(sender, RGBColors.color1);
            lastColorBtn = RGBColors.color1;
            OpenChildForm(new frmShop(Status));
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            if (status == LoginStatus.LoggedIn) {
                ActivateButton(sender, RGBColors.color2);
                lastColorBtn = RGBColors.color2;
                OpenChildForm(new frmCart());
            }
            else
            {
                Nofitication nofitication = new Nofitication("Login required");
                nofitication.ShowDialog();
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (status == LoginStatus.LoggedIn) {
                ActivateButton(sender, RGBColors.color3);
                lastColorBtn = RGBColors.color3;
                OpenChildForm(new frmOrder());
            }
            else
            {
                Nofitication nofitication = new Nofitication("Login required");
                nofitication.ShowDialog();
            }
        }
        private void btn_History_Click(object sender, EventArgs e)
        {
            if (status == LoginStatus.LoggedIn)
            {
                ActivateButton(sender, RGBColors.color4);
                lastColorBtn = RGBColors.color4;
                OpenChildForm(new frmHistory());
            }
            else
            {
                Nofitication nofitication = new Nofitication("Login required");
                nofitication.ShowDialog();
            }
        }
        
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            lastColorBtn = RGBColors.color5;
            CheckLogin();
        }
        private void CheckLogin()
        {
            if (status == LoginStatus.LoggedIn)
            {
                OpenChildForm(new frmUserProfile(this));
            }
            else
            {
                OpenChildForm(new frmLogin(this));
            }
        }
        public void OnLoginFailure(string errorMessage)
        {
            Nofitication nofitication = new Nofitication(errorMessage);
            nofitication.ShowDialog();
            status = LoginStatus.LoggedOut;
        }
        public void OnLoginSuccess()
        {
            Nofitication nofitication = new Nofitication("Login Success");
            nofitication.ShowDialog();
            status = LoginStatus.LoggedIn;
            CheckLogin();
        }
        public void Logout()
        {
            status = LoginStatus.LoggedOut;
            CheckLogin();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private enum LoginStatus
        {
            LoggedOut,
            LoggedIn
            
        }
        private LoginStatus status
        {
            get; set ;
        }
    }
}
