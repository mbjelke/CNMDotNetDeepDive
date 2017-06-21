using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phones.Models
{
    public class PhoneMfgViewModel
    {
        public List<Phone> phones { get; set; }
        public SelectList mfgs { get; set; }
        public string phoneMfg { get; set; }
    }
}
