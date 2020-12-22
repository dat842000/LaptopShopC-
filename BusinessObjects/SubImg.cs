using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class SubImg : BusinessObject
    {
        public int SubImgID { get; set; }
        public int ProductID { get; set; }
        public string UrlImg { get; set; }
    }
}
