using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "Copyright Year")]
        public int CopyrightYear { get; set; }
    }
}
