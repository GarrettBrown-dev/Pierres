using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PT.Models
{
    public class PTContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Treat> Treats { get; set; }
        public DbSet<Flavor> Flavors { get; set; }
        public DbSet<TreatFlavor> TreatFlavor { get; set; }
        public PTContext(DbContextOptions options) : base(options) { }

    }
}