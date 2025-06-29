using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenLogic.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public string ProductTitle => Product?.Title ?? "";
        public int UnitPrice => Product?.ForSellPrice ?? 0;
        public int TotalPrice => UnitPrice * Quantity;
    }
}
