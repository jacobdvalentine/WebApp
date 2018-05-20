using Microsoft.EntityFrameworkCore;
using vega.Model;

namespace vega.Persistence
{
    // DbContext class that inherits Entity Framework DbContext
    public class VegaDbContext : DbContext
    {
        // Constructor for using Entity Framework
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            // Later use in controller, direct injecting DbContext dependencies
        }

        //
        public DbSet<Make> Makes { get; set; }
        public DbSet<Make> Features { get; set; }
    }
}