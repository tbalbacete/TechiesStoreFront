using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechiesStoreFront.Shared.Models.CategoryModels
{
    public class CategoryEdit
    {
        [Required]
        public string Name { get; set; }
    }
}
