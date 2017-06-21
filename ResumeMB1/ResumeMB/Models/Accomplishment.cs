using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeMB.Models
{
    public class Accomplishment

    {
        public int AccomplishmentId { get; set; }
        public int JobID { get; set; }

        [Required]
        [Display(Name ="Accomplishment")]
        [RegularExpression(@"^[A-Z]/d.*$",
           ErrorMessage = "Please enter an Accomplishment starting with an uppercase letter or a number."
            )]
        public string Accomp { get; set; }

        public virtual Job Job { get; set; }
              
    }
}
