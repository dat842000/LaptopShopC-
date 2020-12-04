using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class HistoryPresenter : Presenter<IHistoryView>
    {
        public HistoryPresenter(IHistoryView view) : base(view)
        {
        }
        public void Display()
        {
            View.ListHistory = Model.getHistory();
        }
    }
}
