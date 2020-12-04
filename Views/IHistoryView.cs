using ProjectCsharp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Views
{
    public interface IHistoryView : IView
    {

        List<OrderModel> ListHistory { set; }
    }
}
