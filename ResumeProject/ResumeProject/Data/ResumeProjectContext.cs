using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ResumeProject.Models
{
    public class ResumeProjectContext : DbContext
    {
        public ResumeProjectContext (DbContextOptions<ResumeProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ResumeProject.Models.Person> Person { get; set; }
    }
}
