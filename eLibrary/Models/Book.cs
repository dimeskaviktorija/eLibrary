using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string BookURL { get; set; }
        public string BookArtUrl { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}