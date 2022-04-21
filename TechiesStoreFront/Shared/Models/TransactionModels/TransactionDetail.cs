using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.OrderedItemModels;

namespace TechiesStoreFront.Shared.Models.TransactionModels
{
    public class TransactionDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double AmountSpent { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}
