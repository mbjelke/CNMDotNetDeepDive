using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeMB.Models;

namespace ResumeMB.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ResumeMB.Models.Person> Person { get; set; }

        public DbSet<ResumeMB.Models.Accomplishment> Accomplishments { get; set; }

        public DbSet<ResumeMB.Models.Affiliation> Affiliations { get; set; }

        public DbSet<ResumeMB.Models.Certification> Certifications { get; set; }

        public DbSet<ResumeMB.Models.Education> Education { get; set; }

        public DbSet<ResumeMB.Models.Job> Experience { get; set; }

        public DbSet<ResumeMB.Models.ProfessionalSummary> ProfessionalSummary { get; set; }

        public DbSet<ResumeMB.Models.Qualification> Qualifications { get; set; }

        public DbSet<ResumeMB.Models.Reference> References { get; set; }

    }
}
