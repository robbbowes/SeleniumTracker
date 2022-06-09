using Microsoft.EntityFrameworkCore;
using SeleniumTracker.Entities.Enums;
using SeleniumTracker.Entities.Seeding;
using SeleniumTracker.Models;
using System.Collections.Generic;
using System.Reflection;

namespace SeleniumTracker.Data
{
    public class SeleniumTrackerDbContext : DbContext
    {
        public SeleniumTrackerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Codeline> Codelines { get; set; }
        public DbSet<Autotest> Autotests { get; set; }
        public DbSet<TestLinkAnnotation> TestLinkAnnotations { get; set; }
        public DbSet<Failure> Failures { get; set; }
        public DbSet<Resolution> Resolutions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeleniumTrackerSeeding.Seed(modelBuilder);
        }

    }
}
