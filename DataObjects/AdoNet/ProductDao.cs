﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class ProductDao : IProductDao
    {
        static Db db = new Db();

        public List<Product> GetProductsByBrand(int BrandID, string sortExpression)
        {
            string sql =
            @"SELECT ProductID, ProductName, UnitPrice, Specs, RatingPoint, ImgUrl, Quantity
                FROM [Product] P JOIN [Brand] B ON P.BrandID = B.BrandID
               WHERE B.BrandID = @BrandID".OrderBy(sortExpression);

            object[] parms = { "@BrandID", BrandID };
            return db.Read(sql, Make, parms).ToList();
        }

        public List<Product> SearchProducts(string ProductName, string sortExpression)
        {
            string sql =
                @"SELECT ProductID, ProductName, UnitPrice, Specs, RatingPoint, ImgUrl, Quantity
                    FROM [Product] ";

            var where = new StringBuilder();
            if (!string.IsNullOrEmpty(ProductName))
                where.Append("  WHERE ProductName LIKE @ProductName ");

            sql += where.ToString().OrderBy(sortExpression);

            object[] parms = { "@ProductName", "%" + ProductName + "%" };
            return db.Read(sql, Make, parms).ToList();
        }

        public List<Product> GetProducts()
        {
            string sql =
             @"SELECT ProductID, ProductName, UnitPrice, Specs, RatingPoint, ImgUrl, Quantity,
                      BrandID
                 FROM [Product]";
            return db.Read(sql, Make).ToList();
        }
        public Product GetProduct(int ProductID)
        {
            string sql =
             @"SELECT ProductID, ProductName, UnitPrice, Specs, RatingPoint, ImgUrl, Quantity,
                      BrandID
                 FROM [Product] WHERE @ProductID = ProductID";
            object[] parms = { "@ProductID", ProductID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }


        // creates Product object from IDataReader

        private static Func<IDataReader, Product> Make = reader =>
          new Product
          {
              ProductID = reader["ProductId"].AsId(),
              ProductName = reader["ProductName"].AsString(),
              UnitPrice = reader["UnitPrice"].AsDouble(),
              Specs = reader["Specs"].AsString(),
              RatingPoint = reader["RatingPoint"].AsDouble(),
              ImgUrl = reader["ImgUrl"].AsString(),
              Quantity = reader["Quantity"].AsInt()
          };

        // creates query parameter list from Product object

        private object[] Take(Product product)
        {
            return new object[]
            {
                "@ProductID", product.ProductID,
                "@ProductName", product.ProductName,
                "@UnitPrice", product.UnitPrice,
                "@Specs", product.Specs,
                "@RatingPoint", product.RatingPoint,
                "@ImgUrl", product.ImgUrl,
                "@Quantity", product.Quantity
            };
        }


    }
}
