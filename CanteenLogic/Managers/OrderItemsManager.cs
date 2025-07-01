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
    public static class OrderItemsManager
    {
        static DbManager dbManager = new DbManager();

        public static int AddOrderItem(OrderItem item)
        {
            string sql = "INSERT INTO OrderItems (OrderId, ProductId, Quantity, UnitPrice) VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice)";
            var parameters = new Dictionary<string, object>
            {
                { "@OrderId", item.OrderId },
                { "@ProductId", item.ProductId },
                { "@Quantity", item.Quantity },
                { "@UnitPrice", item.UnitPrice } // save current product price
            };
            return dbManager.ExecuteNonQuery(sql, parameters);
        }

        public static List<OrderItem> GetOrderItems(int orderId)
        {
            List<OrderItem> items = new();
            string sql = "SELECT * FROM OrderItems WHERE OrderId = @OrderId";
            var parameters = new Dictionary<string, object> { { "@OrderId", orderId } };
            var dt = dbManager.GetDataTable(sql, parameters);
            foreach (DataRow row in dt.Rows)
            {
                items.Add(new OrderItem
                {
                    Id = Convert.ToInt32(row["Id"]),
                    OrderId = Convert.ToInt32(row["OrderId"]),
                    ProductId = Convert.ToInt32(row["ProductId"]),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    UnitPrice = Convert.ToInt32(row["UnitPrice"]),
                    Product = ProductsManager.GetProductById(Convert.ToInt32(row["ProductId"]))
                });
            }
            return items;
        }

        public static int UpdateOrderItem(OrderItem item)
        {
            string sql = "UPDATE OrderItems SET ProductId = @ProductId, Quantity = @Quantity WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
        {
            { "@Id", item.Id },
            { "@ProductId", item.ProductId },
            { "@Quantity", item.Quantity }
        };
            return dbManager.ExecuteNonQuery(sql, parameters);
        }

        public static int DeleteOrderItem(int id)
        {
            string sql = "DELETE FROM OrderItems WHERE Id = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            return dbManager.ExecuteNonQuery(sql, parameters);
        }

        public static int DeleteItemsByOrderId(int orderId)
        {
            string sql = "DELETE FROM OrderItems WHERE OrderId = @OrderId";
            var parameters = new Dictionary<string, object> { { "@OrderId", orderId } };
            return dbManager.ExecuteNonQuery(sql, parameters);
        }
    }
}
