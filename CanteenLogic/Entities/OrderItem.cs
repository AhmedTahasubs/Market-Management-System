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
        public int UnitPrice { get; set; } // Not from Product anymore
        public Product? Product { get; set; }

        public string ProductTitle => Product?.Title ?? "";
        public int TotalPrice => UnitPrice * Quantity;
    }
}
