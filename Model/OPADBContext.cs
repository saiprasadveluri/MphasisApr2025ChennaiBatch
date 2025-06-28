using Microsoft.EntityFrameworkCore;
namespace OnlinePharmacyAppAPI.Model
{
    public class OPADBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var configSection = configBuilder.GetSection("ConnectionStrings");

            var connectionString = configSection["DefaultConnection"] ?? null;

            optionsBuilder.UseSqlServer(connectionString);

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<StockReplenishment> stocks{ get; set; }
        public DbSet<AlternativeMedicine> alternativeMedicines{ get; set; }
        public DbSet<Profile> profiles { get; set; }

        public OPADBContext(DbContextOptions opts) : base(opts)

        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AlternativeMedicine>()
                .HasOne(am => am.OriginalMedicine)
                .WithMany()
                .HasForeignKey(am => am.OriginalMedicineId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AlternativeMedicine>()
                .HasOne(am => am.SubstituteMedicine)
                .WithMany()
                .HasForeignKey(am => am.SubstituteMedicineId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
