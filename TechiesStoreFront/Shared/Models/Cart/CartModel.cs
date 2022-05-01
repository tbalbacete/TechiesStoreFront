using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.ProductModels;

namespace TechiesStoreFront.Shared.Models.Cart
{
    public class CartModel
    {
        public List<ProductDetail> Items { get; set; } = new List<ProductDetail>();

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in Items)
                {
                    total += item.Price;
                }
                return total;
            }
        }
        public DateTime LastAccessed { get; set; }
        public int TimeToLiveInSeconds { get; set; }
    }
}
