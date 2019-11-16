using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int Id { set; get; }
        [Required]
        public string Title { set; get; }
        [Required]
        public  string Author { set; get; }
        [Required]
        public decimal Price { set; get; }

    }
}
