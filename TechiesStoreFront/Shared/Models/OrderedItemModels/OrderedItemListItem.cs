using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.OrderedItemModels
{
    public class OrderedItemListItem
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int QuantityOrdered { get; set; }
    }
}
