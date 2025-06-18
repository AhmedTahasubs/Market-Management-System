using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenLogic.Entities;

namespace CanteenLogic
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string? CustomerName { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public int TotalAmount => Items.Sum(i => i.TotalPrice);
        public override string ToString()
        {
            return $"Order #{Id} by {CustomerName} on {OrderDate:d} - Total: {TotalAmount} TL";
        }
    }
}
