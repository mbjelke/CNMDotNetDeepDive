using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


// not yet migrated - play away!  05/30/2017

namespace ResumeMB.Models
{
    public class Certification
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Certification or License Name")]
        public string CertName { get; set; }

        [Display(Name ="Issuing Authority")]
        public string CertAuthority { get; set; }

        [Display(Name ="License Number")]
        public string LicenseNum { get; set; }

        [Required]
        [Display(Name ="Issue Date")]
        public DateTime From { get; set; }

        [Display(Name ="Expiry Date")]
        public DateTime To { get; set; }

        [Display(Name ="License Does Not Expire?")]
        public bool IsEternal { get; set; }

        [Display(Name ="Enter Certification URL (if applicable)")]
        [DataType(DataType.Url)]
        public string CertURL { get; set; }

    }
}
