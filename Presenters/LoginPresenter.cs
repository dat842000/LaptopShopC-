using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class LoginPresenter : Presenter<ILoginView>
    {
        ILoginView view;
        public LoginPresenter(ILoginView view) : base(view)
        {
            this.view = view;
        }
        public void Login()
        {
            string username = View.UsernameLogin;
            string password = View.PasswordLogin;

            if(Model.Login(username, password))
            {
                this.view.OnLoginSuccess();
            } else {
                this.view.OnLoginFailure("Login failed");
            } 

        }
    }
}
