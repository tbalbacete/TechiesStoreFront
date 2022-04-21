using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechiesStoreFront.Server.Models
{
    public class OrderedItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }

        [Required]
        public int ItemOrderedId { get; set; }
        public virtual Product Product { get; set; }

        public int QuantityOrdered { get; set; }
    }
}
