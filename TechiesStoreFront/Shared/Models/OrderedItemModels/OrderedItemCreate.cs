using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.OrderedItemModels
{
    public class OrderedItemCreate
    {
        [Required]
        public int TransactionId { get; set; }

        [Required]
        public int ItemOrderedId { get; set; }

        [Required]
        public int QuantityOrdered { get; set; }

    }
}
