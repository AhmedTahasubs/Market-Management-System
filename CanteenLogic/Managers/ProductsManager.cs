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
                    Price = Convert.ToInt32(row["Price"]),
                    UnitsInStock = Convert.ToInt32(row["UnitsInStock"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"])
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
                    Price = Convert.ToInt32(row["Price"]),
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
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Product
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Title = row["Title"].ToString(),
                    Price = Convert.ToInt32(row["Price"]),
                    UnitsInStock = Convert.ToInt32(row["UnitsInStock"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"])
                };
            }
            return null;
        }
        public static int AddProduct(Product product)
        {
            string query = "INSERT INTO Products (Title, Price, UnitsInStock, CategoryId) VALUES (@Title, @Price, @UnitsInStock, @CategoryId)";
            var parameters = new Dictionary<string, object>
            {
                { "@Title", product.Title },
                { "@Price", product.Price },
                { "@UnitsInStock", product.UnitsInStock },
                { "@CategoryId", product.CategoryId }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int UpdateProduct(Product product)
        {
            string query = "UPDATE Products SET Title = @Title, Price = @Price, UnitsInStock = @UnitsInStock WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Title", product.Title },
                { "@Price", product.Price },
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
    }
}
