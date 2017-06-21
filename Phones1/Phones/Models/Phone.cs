using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Phones.Models
{
    public class Phone
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please enter a manufacturer name that is fewer than 20 characters long.")]
        [Display(Name = "Manufacturer")]
        public string Mfg { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please enter a model name that is fewer than 20 characters long.")]
        public string Model { get; set; }

        [StringLength(20, ErrorMessage = "Please enter a size that is fewer than 20 characters long.")]
        [Display(Name = "Screen Size")]
        public string Size { get; set; }

        [StringLength(20, ErrorMessage = "Please enter a color name that is fewer than 20 characters long.")]
        public string Color { get; set; }
                
        [Display(Name ="Pixels in mp")]
        [Range(2,100)]
        public int? CameraPix { get; set; }
                
        [Required]
        [DataType(DataType.Currency)]
        [Range(.01, 100)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please enter an OS name that is fewer than 20 characters long.")]
        [Display(Name = "Operating System")]
        [RegularExpression(@"((?:[Ww](indows))?)((?:[Aa](ndroid))?)(?:(iOS)?)", ErrorMessage="Please enter Windows, Android, or iOS.")]
        public string OS { get; set; }

        [StringLength(20, ErrorMessage = "Please enter a condition that is fewer than 20 characters long.")]
        public string Condition { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Range(typeof(DateTime), "1/1/1980", "12/31/2025")]
        [Display(Name = "Release Date")]
        public DateTime? Release { get; set; }

    }
}
