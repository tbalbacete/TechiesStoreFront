using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.ProductModels
{
    public class ProductCreate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public int CategoryId { get; set; }
    }
}
