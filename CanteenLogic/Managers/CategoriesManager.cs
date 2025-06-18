using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenDataBase;

namespace CanteenLogic
{
    public static class CategoriesManager
    {
        static DbManager dbManager = new DbManager();
        public static CategoriesList GetCategories()
        {
            CategoriesList categories = new CategoriesList();
            string query = "SELECT * FROM Categories";
            var dt = dbManager.GetDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                Category category = new Category
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()
                };
                categories.Add(category);
            }
            return categories;
        }
        public static int AddCategory(Category category)
        {
            string query = "INSERT INTO Categories (Name) VALUES (@Name)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", category.Name }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int UpdateCategory(Category category)
        {
            string query = "UPDATE Categories SET Name = @Name WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", category.Name },
                { "@Id", category.Id }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int DeleteCategory(int id)
        {
            string query = "DELETE FROM Categories WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static CategoriesList GetCategoriesByName(string name)
        {
            CategoriesList categories = new CategoriesList();
            string query = "SELECT * FROM Categories WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", "%" + name + "%" }
            };
            var dt = dbManager.GetDataTable(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                Category category = new Category
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()
                };
                categories.Add(category);
            }
            return categories.Count > 0 ? categories : null;
        }
    }
}
