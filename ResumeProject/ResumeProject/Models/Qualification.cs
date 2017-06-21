using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeProject.Models
{
    public class Qualification
    {
		public int Id { get; set; }

		[RegularExpression(@"^[A-Z].*$",
		 ErrorMessage = "Please, enter a Skill or Qualification starting with an uppercase letter."
		  )]
		public string Skill { get; set; }

		//navigation
		// Qualifications get one Person
		public virtual Person Person { get; set; }
	}
}
