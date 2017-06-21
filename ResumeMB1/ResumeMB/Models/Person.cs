using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeMB.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name="First Name")]
        [StringLength(25)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-''/'\s]*$",
           ErrorMessage = "Please, enter your first name starting with an uppercase letter."
            )]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        [StringLength(1)]
        [RegularExpression(@"^[A-Z]$",
           ErrorMessage = "Please, enter your middle initial as an uppercase letter."
            )]
        public string MiddleInit { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(40)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-''/'\s]*$",
           ErrorMessage = "Please, enter your last name starting with an uppercase letter."
            )]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$",
           ErrorMessage = "Please, enter your city starting with an uppercase letter."
            )]
        [StringLength(25)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [DataType(DataType.PostalCode, ErrorMessage = "Please, enter your zip code is the proper format.")]
        public string Zip { get; set; }

        [DataType(DataType.Url)]
        public string Website { get; set; }

        [DataType(DataType.Url)]
        public string LinkedIn { get; set; }

        [DataType(DataType.Url)]
        public string Facebook { get; set; }

        [DataType(DataType.Url)]
        public string Twitter { get; set; }
        
    }
}
