using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Title { get; set; }

        public int ISBN { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
