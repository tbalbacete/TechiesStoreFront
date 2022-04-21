using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.TransactionModels
{
    public class TransactionCreate
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public double AmountSpent { get; set; }
    }
}
