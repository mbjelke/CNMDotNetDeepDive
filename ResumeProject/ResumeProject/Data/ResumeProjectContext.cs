using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Models;

namespace ResumeProject.Models
{
    public class ResumeProjectContext : DbContext
    {
        public ResumeProjectContext (DbContextOptions<ResumeProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ResumeProject.Models.Person> Person { get; set; }

        public DbSet<ResumeProject.Models.Job> Job { get; set; }

        public DbSet<ResumeProject.Models.Affiliation> Affiliation { get; set; }

        public DbSet<ResumeProject.Models.Certification> Certification { get; set; }

        public DbSet<ResumeProject.Models.ProfessionalSummary> ProfessionalSummary { get; set; }

        public DbSet<ResumeProject.Models.Education> Education { get; set; }

        public DbSet<ResumeProject.Models.Qualification> Qualification { get; set; }

        public DbSet<ResumeProject.Models.Reference> Reference { get; set; }
    }
}
