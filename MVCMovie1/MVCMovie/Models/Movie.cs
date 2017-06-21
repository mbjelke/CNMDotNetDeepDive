using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2,
            ErrorMessage ="Please, enter a movie title.")]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString="{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime),"1/1/1900","1/1/2020")]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$",
           ErrorMessage ="Please, enter a genre starting with an uppercase letter."
            )]
        public string Genre { get; set; }

        [Required]
        [Range(.01, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", 
            ErrorMessage = "Please, enter a rating starting with an uppercase letter.")]
        [StringLength(5, MinimumLength = 1)]
        public string Rating { get; set; }

        // @ allows us to have stuff in here that doesn't have to be escaped, so \s works and doesn't need \\s
        // ^ = beginning of line
        // [A-Z] = first character must be upper case
        // + = 1 or more
        // [a-zA-Z''-'\s] = a-z or A-Z or ' or - or space
        // * = any number of times
        // $ = end of line

    }
}
