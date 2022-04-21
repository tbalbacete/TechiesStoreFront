using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechiesStoreFront.Server.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public double AmountSpent { get; set; }

        [Required]
        public DateTime DateofTransaction { get; set; }


    }
}
