using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models
{
    public class AppliContext:DbContext
    {
        public DbSet<Hospitals> hospitals { get; set; }
        public DbSet<Doctors> doctors { get; set; }
        public DbSet<Labs> labs { get; set; }
        public DbSet<Patients> patients { get; set; }
        public AppliContext(DbContextOptions<AppliContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
