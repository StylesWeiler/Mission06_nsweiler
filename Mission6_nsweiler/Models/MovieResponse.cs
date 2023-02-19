using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_nsweiler.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int movieId { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public string lentTo { get; set; }

        [StringLength(25)]
        public string notes { get; set; }

        public bool edited { get; set; }

        // Build the foreign key relationship
        [Required]
        public int categoryId { get; set; } // foreign key
        public Category category { get; set; } // paired with an instance of the Category type creates a connection between the two tables
    }
}
