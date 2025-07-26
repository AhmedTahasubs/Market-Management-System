using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenLogic
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int OriginalPrice { get; set; } 
        public int ForSellPrice { get; set; }  
        public int Price => ForSellPrice;      
        public int Profit => ForSellPrice - OriginalPrice; 
        public int UnitsInStock { get; set; }
        public int? CategoryId { get; set; }
        public bool IsEmpty => UnitsInStock <= 0;

        public override string ToString()
        {
            return $"{Title} - Sell: {ForSellPrice} TL - Stock: {UnitsInStock} (Profit: {Profit} TL)";
        }
    }
}
