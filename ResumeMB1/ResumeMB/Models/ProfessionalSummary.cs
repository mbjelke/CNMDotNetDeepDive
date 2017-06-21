using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeMB.Models
{
    public class ProfessionalSummary
    {
        public int Id { get; set; }

        [Display(Name ="Enter your Professional Statement. This may be as long or short as you wish.")]
        public string ProfessionalStatement { get; set; }
    }
}
