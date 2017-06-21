using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeProject.Models
{
	public class Reference
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "First Name is required")]
		[Display(Name = "First Name")]
		[StringLength(25)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-''/'\s]*$",
		   ErrorMessage = "Please, enter your first name starting with an uppercase letter."
			)]
		public string ReferenceFirstName { get; set; }

		[Required(ErrorMessage = "Last Name is required")]
		[Display(Name = "Last Name")]
		[StringLength(40)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-''/'\s]*$",
		   ErrorMessage = "Please, enter your last name starting with an uppercase letter."
			)]
		public string ReferenceLastName { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-''/'\s]*$",
			ErrorMessage = "Please, enter your reference's description starting with an uppercase letter."
			)]
		public string ReferenceDesc { get; set; }

		[Required(ErrorMessage = "Phone number is required")]
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Phone Number")]
		[DisplayFormat(ApplyFormatInEditMode = true)]
		public string ReferencePhone { get; set; }

		[Required(ErrorMessage = "Email address is required")]
		[DataType(DataType.EmailAddress)]
		public string ReferenceEmail { get; set; }

		// because there is no 'set' it's just Full Name
		[NotMapped]
		public string ReferenceFullName
		{
			get
			{
				return String.Format("{0} {1}", ReferenceFirstName, ReferenceLastName);
			}
		}
		//navigation
		// References get one Person
		public virtual Person Person { get; set; }
	}
}
