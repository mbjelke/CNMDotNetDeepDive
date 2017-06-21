using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeProject.Models
{
    public class Education
    {
		public int ID { get; set; }

		[Required]
		[Display(Name = "Organization Name")]
		public string OrgName { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]
		[Display(Name = "Starting Year")]
		public DateTime From { get; set; }

		[Required]
		[Display(Name = "Graduating Year (if applicable)")]
		public DateTime EndDate { get; set; }

		[Required]
		public bool isCurrent { get; set; }

		[Display(Name = "Degree Attained (if applicable)")]
		public string DegreeAttained { get; set; }

		[Required]
		[Display(Name = "Fields(s) of Concentration")]
		public string ConcentrationIn { get; set; }

		//navigation
		// Educations get one Person
		public virtual Person Person { get; set; }
	}
}
