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
    public partial class frmLogin : Form, ILoginView
    {
        private LoginPresenter loginPresenter;
        private bool cancelClose;
        private frmMainMenu parent;

        public frmLogin(frmMainMenu parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.Closing += frmLogin_FormClosing;
            loginPresenter = new LoginPresenter(this);
            //
            lblUsername.Text = "admin";
            lblPassword.Text = "secret";
        }

        public string Username
        {
            get { return lblUsername.Text.Trim(); }
        }
        public string Password
        {
            get { return lblPassword.Text.Trim(); }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginPresenter.Login();              
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Login failed");
                cancelClose = true;
            }
        }

        private void frmLogin_FormClosing(object sender,CancelEventArgs e)
        {
            e.Cancel = cancelClose;
            cancelClose = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        public void OnLoginSuccess(){
            parent.OnLoginSuccess();
        }

        public void OnLoginFailure(string errorMessage){
            parent.OnLoginFailure(errorMessage);
        }

    }
}
