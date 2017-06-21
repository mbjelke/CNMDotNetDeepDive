using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Phones.Models
{
    public class PhonesContext : DbContext
    {
        public PhonesContext (DbContextOptions<PhonesContext> options)
            : base(options)
        {
        }

        public DbSet<Phones.Models.Phone> Phone { get; set; }
    }
}
