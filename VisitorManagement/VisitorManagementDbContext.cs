using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace VisitorManagement
{
    public class VisitorManagementDbContext : DbContext
    {
        public VisitorManagementDbContext(DbContextOptions<VisitorManagementDbContext> options) : base(options) { }

        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Host> Hosts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitor>()
                .HasOne(v => v.Locations)
                .WithMany(l => l.Visitors)
                .HasForeignKey(v => v.LocationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
