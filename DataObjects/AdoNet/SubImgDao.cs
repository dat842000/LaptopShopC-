using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class SubImgDao : ISubImgDao
    {
        static Db db = new Db();
        public List<SubImg> GetSubImgByProductID(int ProductID)
        {
            string sql =
            @"SELECT S.ImgUrl
                FROM [SubImg] S INNER JOIN [Product] P ON P.ProductID = S.ProductID
                WHERE S.ProductID = @ProductID";
            object[] parms = { "@ProductID", ProductID };
            return db.Read(sql, Make, parms).ToList();
        }
        private static Func<IDataReader, SubImg> Make = reader =>
          new SubImg
          {
              UrlImg = reader["ImgUrl"].AsString()
          };
        private object[] Take(SubImg subImg)
        {
            return new object[]
            {
                
            };
        }
    }
}
