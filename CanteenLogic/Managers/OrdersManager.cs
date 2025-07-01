using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenDataBase;
using CanteenLogic.Entities;

namespace CanteenLogic
{
    public static class OrdersManager
    {
        static DbManager dbManager = new DbManager();

        public static int AddOrder(Order order)
        {
            string sql = "INSERT INTO Orders (CustomerName, OrderDate) VALUES (@CustomerName, @OrderDate); SELECT SCOPE_IDENTITY();";
            var parameters = new Dictionary<string, object>
        {
            { "@CustomerName", order.CustomerName ?? (object)DBNull.Value },
            { "@OrderDate", order.OrderDate }
        };
            return Convert.ToInt32(dbManager.ExecuteScalar(sql, parameters));
        }

        public static Order? GetOrderById(int id)
        {
            string sql = "SELECT * FROM Orders WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            var dt = dbManager.GetDataTable(sql, parameters);
            if (dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];
            return new Order
            {
                Id = Convert.ToInt32(row["Id"]),
                CustomerName = row["CustomerName"].ToString(),
                OrderDate = Convert.ToDateTime(row["OrderDate"])
            };
        }

        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new();
            string sql = "SELECT * FROM Orders";
            var dt = dbManager.GetDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                orders.Add(new Order
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CustomerName = row["CustomerName"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"])
                });
            }
            return orders;
        }

        public static int UpdateOrder(Order order)
        {
            string sql = "UPDATE Orders SET CustomerName = @CustomerName, OrderDate = @OrderDate WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
        {
            { "@Id", order.Id },
            { "@CustomerName", order.CustomerName ?? (object)DBNull.Value },
            { "@OrderDate", order.OrderDate }
        };
            return dbManager.ExecuteNonQuery(sql, parameters);
        }

        public static int DeleteOrder(int id)
        {
            OrderItemsManager.DeleteItemsByOrderId(id);
            string sql = "DELETE FROM Orders WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            return dbManager.ExecuteNonQuery(sql, parameters);
        }
        public static int CreateOrderWithItems(Order order)
        {
            int orderId = AddOrder(order); // Save order
            foreach (var item in order.Items)
            {
                item.OrderId = orderId; // Link item to the new order
                OrderItemsManager.AddOrderItem(item); // Save item
            }
            return orderId;
        }
        public static List<object> GetOrdersSummary()
        {
            string sql = @"
            SELECT o.Id, o.CustomerName, o.OrderDate, 
                    ISNULL(SUM(oi.Quantity * oi.UnitPrice), 0) AS TotalAmount
            FROM Orders o
            LEFT JOIN OrderItems oi ON o.Id = oi.OrderId
            GROUP BY o.Id, o.CustomerName, o.OrderDate
            ORDER BY o.OrderDate DESC";

            var dt = dbManager.GetDataTable(sql);

            List<object> list = new();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CustomerName = row["CustomerName"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]),
                    TotalAmount = Convert.ToDecimal(row["TotalAmount"])
                });
            }

            return list;
        }
        public static List<Order> SearchOrdersByCustomerName(string keyword)
        {
            string sql = "SELECT * FROM Orders WHERE CustomerName LIKE @Keyword";
            var parameters = new Dictionary<string, object>
            {
                { "@Keyword", $"%{keyword}%" }
            };

            var dt = dbManager.GetDataTable(sql, parameters);
            List<Order> orders = new();

            foreach (DataRow row in dt.Rows)
            {
                var order = new Order
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CustomerName = row["CustomerName"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]),
                };

                // Load items if needed
                order.Items = OrderItemsManager.GetOrderItems(order.Id);
                foreach (var item in order.Items)
                {
                    item.Product = ProductsManager.GetProductById(item.ProductId);
                }

                orders.Add(order);
            }

            return orders;
        }
        public static List<Order> SearchOrdersByMonth(int month)
        {
            string sql = "SELECT * FROM Orders WHERE MONTH(OrderDate) = @Month";
            var parameters = new Dictionary<string, object>
            {
                { "@Month", month }
            };

            var dt = dbManager.GetDataTable(sql, parameters);
            List<Order> orders = new();

            foreach (DataRow row in dt.Rows)
            {
                var order = new Order
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CustomerName = row["CustomerName"].ToString(),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]),
                };

                order.Items = OrderItemsManager.GetOrderItems(order.Id);
                foreach (var item in order.Items)
                {
                    item.Product = ProductsManager.GetProductById(item.ProductId);
                }

                orders.Add(order);
            }

            return orders;
        }
    }
}
