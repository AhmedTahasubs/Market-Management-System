using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenDataBase;

namespace CanteenLogic
{
    public static class ProductsManager
    {
        static DbManager dbManager = new DbManager();
        public static ProductsList GetProducts()
        {
            ProductsList products = new ProductsList();
            string query = "SELECT * FROM Products";
            var dt = dbManager.GetDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Title = row["Title"].ToString(),
                    OriginalPrice = Convert.ToInt32(row["OriginalPrice"]),
                    ForSellPrice = Convert.ToInt32(row["ForSellPrice"]),
                    UnitsInStock = Convert.ToInt32(row["UnitsInStock"]),
                    CategoryId = row["CategoryId"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["CategoryId"])
                };
                products.Add(product);
            }
            return products;
        }
        public static ProductsList? GetProductsByName(string name)
        {
            ProductsList products = new ProductsList();
            string query = "SELECT * FROM Products WHERE Title LIKE @Name";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", "%" + name + "%" }
            };

            var dt = dbManager.GetDataTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Title = row["Title"].ToString(),
                    OriginalPrice = Convert.ToInt32(row["OriginalPrice"]),
                    ForSellPrice = Convert.ToInt32(row["ForSellPrice"]),
                    UnitsInStock = Convert.ToInt32(row["UnitsInStock"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"])
                };

                products.Add(product);
            }

            return products.Count > 0 ? products : null;
        }
        public static Product? GetProductById(int id)
        {
            string query = "SELECT * FROM Products WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            var dt = dbManager.GetDataTable(query, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            Product product = new Product
            {
                Id = Convert.ToInt32(row["Id"]),
                Title = row["Title"].ToString(),
                OriginalPrice = Convert.ToInt32(row["OriginalPrice"]),
                ForSellPrice = Convert.ToInt32(row["ForSellPrice"]),
                UnitsInStock = Convert.ToInt32(row["UnitsInStock"]),
                CategoryId = Convert.ToInt32(row["CategoryId"])
            };

            return product;
        }
        public static int AddProduct(Product product)
        {
            string query = "INSERT INTO Products (Title, OriginalPrice, ForSellPrice, UnitsInStock, CategoryId) VALUES (@Title, @OriginalPrice, @ForSellPrice, @UnitsInStock, @CategoryId)";
            var parameters = new Dictionary<string, object>
            {
                { "@Title", product.Title },
                { "@OriginalPrice", product.OriginalPrice },
                { "@ForSellPrice", product.ForSellPrice },
                { "@UnitsInStock", product.UnitsInStock },
                { "@CategoryId", product.CategoryId }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int UpdateProduct(Product product)
        {
            string query = "UPDATE Products SET Title = @Title, OriginalPrice = @OriginalPrice, ForSellPrice = @ForSellPrice, UnitsInStock = @UnitsInStock WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Title", product.Title },
                { "@OriginalPrice", product.OriginalPrice },
                { "@ForSellPrice", product.ForSellPrice },
                { "@UnitsInStock", product.UnitsInStock },
                { "@Id", product.Id }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int DeleteProduct(int id)
        {
            string query = "DELETE FROM Products WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static void DecreaseStock(int productId, int quantity)
        {
            string sql = "UPDATE Products SET UnitsInStock = UnitsInStock - @Quantity WHERE Id = @ProductId";
            var parameters = new Dictionary<string, object>
            {
                { "@ProductId", productId },
                { "@Quantity", quantity }
            };

            DbManager dbManager = new DbManager();
            dbManager.ExecuteNonQuery(sql, parameters);
        }
        public static void UpdateUnitsInStock(int productId, int quantityChange)
        {
            string sql = "UPDATE Products SET UnitsInStock = UnitsInStock + @Change WHERE Id = @ProductId";
            var parameters = new Dictionary<string, object>
            {
                { "@Change", quantityChange },
                { "@ProductId", productId }
            };
            DbManager dbManager = new DbManager();
            dbManager.ExecuteNonQuery(sql, parameters);
        }
    }
}
