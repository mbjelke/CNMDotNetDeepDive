using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeProject.Models
{
    public class Job
    {
		public int JobID { get; set; }

		[Required]
		[RegularExpression(@"^([A-Z\d]).*$",
		   ErrorMessage = "Please, enter a Company Name starting with an uppercase letter or number."
			)]
		public string Company { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]
		[StringLength(4)]
		[RegularExpression(@"^[0-9]*$")]
		[Display(Name = "From Year")]
		public string FromYear { get; set; }

		[StringLength(4)]
		[RegularExpression(@"^[0-9]*$")]
		[Display(Name = "To Year")]
		public string ToYear { get; set; }

		[Display(Name = "Current Position")]
		public bool IsCurrent { get; set; }

		public string Description { get; set; }

		// navigation
		// Jobs get one Person
		public virtual Person Person { get; set; }
		// A job gets many accomplishments
		public virtual ICollection<Accomplishment> Accomplishments { get; set; }
	}
}
