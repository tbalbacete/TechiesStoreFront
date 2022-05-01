using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechiesStoreFront.Server.Models
{
    public class OrderedItemEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TransactionId { get; set; }
        public virtual TransactionEntity Transaction { get; set; }

        public int ProductId { get; set; }
        public virtual ProductEntity Product { get; set; }

        public int QuantityOrdered { get; set; }
    }
}
