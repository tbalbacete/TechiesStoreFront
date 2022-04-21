using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.OrderedItemModels
{
    public class OrderedItemDetail
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int ItemOrderedId { get; set; }
        public string ItemName { get; set; }
        public int QuantityOrdered { get; set; }
    }
}
