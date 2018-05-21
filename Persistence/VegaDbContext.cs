using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence
{
    // DbContext class that inherits Entity Framework DbContext
    public class VegaDbContext : DbContext
    {
         // Database sets for context
        public DbSet<Make> Makes { get; set; }
        //public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        // Constructor for using Entity Framework
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            // Later use in controller, direct injecting DbContext dependencies
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<VehicleFeature>().HasKey(vf => new { vf.VehicleId, vf.FeatureId});
        // }
    }
}