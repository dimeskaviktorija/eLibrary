using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace eLibrary.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Required]
        [DisplayName("GenreName")]
        public string GenreName { get; set; }
        public string GenreDesc { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}