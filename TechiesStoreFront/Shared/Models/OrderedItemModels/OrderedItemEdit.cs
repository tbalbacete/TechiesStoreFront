using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.OrderedItemModels
{
    public class OrderedItemEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int TransactionId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int QuantityOrdered { get; set; }
    }
}
