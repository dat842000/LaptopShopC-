using ProjectCsharp.Models;
using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class Presenter<T> where T : IView
    {
        protected static IModel Model { get; private set; }
        static Presenter()
        {
            Model = new Model();
        }
        public Presenter(T view)
        {
            View = view;
        }
        protected T View { get; private set; }
    }
}
