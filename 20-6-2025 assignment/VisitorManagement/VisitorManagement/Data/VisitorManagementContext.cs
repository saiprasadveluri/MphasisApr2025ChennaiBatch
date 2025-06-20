using Microsoft.EntityFrameworkCore;

namespace VisitorManagement.Data
{
    public class VisitorManagementContext:DbContext
    {
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<HostInfo> hostInfos { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public VisitorManagementContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitor>().HasIndex(p => p.VisitorName).IsUnique(true);
            modelBuilder.Entity<HostInfo>().HasIndex(p=>p.HostName).IsUnique(true); 
           
        }

    }
}
