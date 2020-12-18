using ProjectCsharp.Presenters;
using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCsharp
{
    public partial class frmLogin : Form, ILoginView
    {
        private LoginPresenter loginPresenter;
        private RegisterPresenter registerPresenter;
        private bool cancelClose;
        private frmMainMenu parent;
        private string url = "";
        private bool regisState = false;

        public frmLogin(frmMainMenu parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.Closing += frmLogin_FormClosing;
            loginPresenter = new LoginPresenter(this);
            registerPresenter = new RegisterPresenter(this);
            if (genderRegis.Checked) { genderRegis.Text = "Male"; } else { genderRegis.Text = "Female"; }
        }

        public string UsernameLogin
        {
            get { return lb_UsernameLogin.Text.Trim(); }
        }
        public string PasswordLogin
        {
            get { return lb_PasswordLogin.Text.Trim(); }
        }
        public string Username
        {
            get { return userRisgis.Text.Trim(); }
        }
        public string Password
        {
            get { return passRegis.Text.Trim(); }
        }
        public string Fullname
        {
            get { return nameRegis.Text.Trim(); }
        }
        public string Phone
        {
            get { return phoneRegis.Text.Trim(); }
        }

        public string Email
        {
            get { return emailRegis.Text.Trim(); }
        }
        public string Address
        {
            get { return addressRegis.Text.Trim(); }
        }
        public bool Gender
        {
            get 
            {
                return genderRegis.Checked; 
            }
        }

        public string urlImg
        {
            get { return url; }
        }

        public bool State
        {
            set
            {
                regisState = value;
            }
            get 
            { 
                return regisState; 
            }
        }
        private void frmLogin_FormClosing(object sender,CancelEventArgs e)
        {
            e.Cancel = cancelClose;
            cancelClose = false;
        }


        public void OnLoginSuccess(){
            parent.OnLoginSuccess();
        }

        public void OnLoginFailure(string errorMessage){
            parent.OnLoginFailure(errorMessage);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                loginPresenter.Login();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Login failed");
                cancelClose = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            pn_login.Visible = true;
            guna2Transition1.HideSync(pn_login);
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            pn_regis.Visible = true ;
            guna2Transition1.ShowSync(pn_login);
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            userRisgis.Text = "";
            passRegis.Text = "";
            nameRegis.Text = "";
            phoneRegis.Text = "";
            emailRegis.Text = "";
            addressRegis.Text = "";
            genderRegis.Checked = false;
            picRegis.Image = null;
            url = "";
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(url);
            url = userRisgis.Text + fileInfo.Extension;
            registerPresenter.register();
            if (regisState)
            {
                fileInfo.CopyTo(@"D:\Laptrinh\source\repos\ProjectC#\bin\Debug\Images\UserProfileImg\" + userRisgis.Text + fileInfo.Extension);
                Nofitication nofitication = new Nofitication("Register Success");
                nofitication.ShowDialog();
            }
            else
            {
                Nofitication nofitication = new Nofitication("Register failed");
                nofitication.ShowDialog();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picRegis.Image = Image.FromFile(ofd.FileName);
                    url = ofd.FileName;                   
                }
            }
        }

        private void genderRegis_CheckedChanged(object sender, EventArgs e)
        {
            if (genderRegis.Checked) { genderRegis.Text = "Male"; } else { genderRegis.Text = "Female"; }
        }
    }
}
