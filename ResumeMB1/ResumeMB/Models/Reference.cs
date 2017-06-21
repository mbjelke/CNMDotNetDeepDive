using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeMB.Models
{
    public class Reference
    {
        public int Id { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceDesc { get; set; }
        public string ReferencePhone { get; set; }
        public string ReferenceEmail { get; set; }
    }
}
