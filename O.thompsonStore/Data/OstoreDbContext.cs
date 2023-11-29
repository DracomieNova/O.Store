using Microsoft.EntityFrameworkCore;
using O.thompsonStore.Models;
using System.Drawing;

namespace O.thompsonStore.Data
{
    public class OstoreDbContext : DbContext
    {
        public DbSet<MainPoint> info { get; set; }
        public DbSet<Service> Service    { get; set; }
        public DbSet<Parts> Parts { get; set; }

        public OstoreDbContext(DbContextOptions<OstoreDbContext> options) : base(options) { }

    }
}
