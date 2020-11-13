﻿using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class LoginPresenter : Presenter<ILoginView>
    {
        public LoginPresenter(ILoginView view) : base(view)
        {
        }
        public void Login()
        {
            string username = View.Username;
            string password = View.Password;

            Model.Login(username, password);
        }
    }
}
