using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.TransactionModels
{
    public class TransactionListItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double AmountSpent { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}
