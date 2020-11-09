using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class BrandDao : IBrandDao
    {
        static Db db = new Db();

        public List<Brand> GetBrands()
        {
            string sql =
            @"SELECT BrandID, BrandName 
                FROM [Brand]";

            return db.Read(sql, Make).ToList();
        }

        public Brand GetBrandByProduct(int ProductID)
        {
            string sql =
            @"SELECT B.BrandID, BrandName 
                FROM [Brand] B INNER JOIN [Product] P ON P.BrandID = B.BrandID 
               WHERE ProductID = @ProductID";

            object[] parms = { "@ProductID", ProductID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }


        static Func<IDataReader, Brand> Make = reader =>
           new Brand
           {
               BrandID = reader["BrandID"].AsId(),
               BrandName = reader["BrandName"].AsString()  
           };

        object[] Take(Brand brand)
        {
            return new object[]
            {
                "@BrandID", brand.BrandID,
                "@BrandName", brand.BrandName
            };
        }
    }
}
