using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Get a shorter last name. Maximum 50 characters.")]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "Last name must begin with a capital letter.")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Get a shorter first name please. Maximum 50 characters.")]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "Fast name must begin with a capital letter.")]
        [Display(Name ="First Mid Name")]
        public string FirstMidName { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:d}")]
        [DataType(DataType.Date, ErrorMessage ="Please enter a valid date. (MM/DD/YYYY)")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        // This is a navigation property. This is going to help us set up foreign keys and relationships 
        // and pull a child object from a parent object
        public ICollection<Enrollment> Enrollments { get; set; }

		// because there is no 'set' it's just Full Name
		[NotMapped]
		public string FullName
		{
			get
			{
				return String.Format("{0} {1}", FirstMidName, LastName);
			}
		}
	}
}
