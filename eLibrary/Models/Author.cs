using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eLibrary.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [Required]
        public string AuthorName { get; set; }
        public string AuthorDesc { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}