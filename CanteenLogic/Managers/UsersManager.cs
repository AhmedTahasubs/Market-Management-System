using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenDataBase;

namespace CanteenLogic
{
    public static class UsersManager
    {
        static DbManager dbManager = new DbManager();
        public static UsersList GetUsers()
        {
            UsersList users = new UsersList();
            string query = "SELECT * FROM Users";
            var dt = dbManager.GetDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                User user = new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
                users.Add(user);
            }
            return users;
        }
        public static User? GetUserById(int id)
        {
            string query = "SELECT * FROM Users WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            var dt = dbManager.GetDataTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
            }
            return null;
        }
        public static User? GetUserByName(string name)
        {
            string query = "SELECT * FROM Users WHERE Name = @Name";
            var parameters = new Dictionary<string, object> { { "@Name", name } };
            var dt = dbManager.GetDataTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
            }
            return null;
        }
        public static UsersList GetUsersByName(string name)
        {
            UsersList users = new UsersList();
            string query = "SELECT * FROM Users WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object> { { "@Name", "%" + name + "%" } };
            var dt = dbManager.GetDataTable(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                User user = new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
                users.Add(user);
            }
            return users;
        }
        public static bool CheckUserNameExists(string userName)
        {
            string query = "SELECT * FROM Users WHERE Name = @userName";
            var parameters = new Dictionary<string, object> { { "@userName", userName } };
            var dt = dbManager.GetDataTable(query, parameters);
            if (dt == null)
            {
                return false;
            }
            return true;


        }
        public static int AddUser(User user)
        {
            string query = "INSERT INTO Users (Name, UserName, Password, Role) VALUES (@Name, @UserName, @Password, @Role)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", user.Name },
                { "@UserName", user.UserName },
                { "@Password", user.Password },
                { "@Role", user.Role }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int UpdateUser(User user)
        {
            string query = "UPDATE Users SET Name = @Name, UserName = @UserName, Password = @Password, Role = @Role WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", user.Id },
                { "@Name", user.Name },
                { "@UserName", user.UserName },
                { "@Password", user.Password },
                { "@Role", user.Role }
            };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static int DeleteUser(int id)
        {
            string query = "DELETE FROM Users WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            return dbManager.ExecuteNonQuery(query, parameters);
        }
        public static User? GetUserByUsernameAndPassword(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";
            var parameters = new Dictionary<string, object>
            {
                { "@UserName", username },
                { "@Password", password }
            };
            var dt = dbManager.GetDataTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
            }
            return null;
        }


    }
}
