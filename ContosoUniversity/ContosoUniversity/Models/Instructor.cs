using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
	public class Instructor
	{
		public int ID { get; set; }

		[Required]
		[Display(Name = "Last Name")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[Column("FirstName")]
		[Display(Name = "First Name")]
		[StringLength(50)]
		public string FirstMidName { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Hire Date")]
		public DateTime HireDate { get; set; }

		[Display(Name = "Full Name")]
		public string FullName
		{
			get { return LastName + ", " + FirstMidName; }
		}

		public ICollection<CourseAssignment> CourseAssignments { get; set; }
		public OfficeAssignment OfficeAssignment { get; set; }
	}

	// a model to track a list of assigned courses for an instructor during editing and creating an instructor
	// you can not map a property and you can not map a class
	// we do not want ef to go build a table from this

	[NotMapped]
	public class InstructorAssignedCourse
	{
		public int CourseID { get; set; }
		public string Title { get; set; }
		public bool Assigned { get; set; }
	}
}