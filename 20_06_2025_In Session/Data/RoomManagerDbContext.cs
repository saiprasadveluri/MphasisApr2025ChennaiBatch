using Microsoft.EntityFrameworkCore;

namespace RoomManagerMVCApp.Data
{
    public class RoomManagerDbContext:DbContext
    {
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public RoomManagerDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        { 
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetingRoom>().Property(p => p.Capacity).HasDefaultValue(10);
            modelBuilder.Entity<MeetingRoom>().HasIndex(p => p.RoomName).IsUnique(true);
            modelBuilder.Entity<UserInfo>().HasIndex(u=>u.Email).IsUnique(true);
        }
    }
}
