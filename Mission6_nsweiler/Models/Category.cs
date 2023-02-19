using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_nsweiler.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}
