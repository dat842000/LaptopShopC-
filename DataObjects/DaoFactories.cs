using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class DaoFactories
    {
        public static IDaoFactory GetFactory(string dataProvider)
        {

            switch (dataProvider.ToLower())
            {
                case "ado.net": return new AdoNet.DaoFactory();

                default: return new AdoNet.DaoFactory();
            }
        }
    }
}
