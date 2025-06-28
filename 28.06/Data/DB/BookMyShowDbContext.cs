using Microsoft.EntityFrameworkCore;

namespace Book.Data.DB
{
    public class BookMyShowDbContext : DbContext
    {
        public BookMyShowDbContext(DbContextOptions<BookMyShowDbContext> options) : base(options) { }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public virtual DbSet<Theatre> Theatres { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MovieLanguage> MovieLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasKey(e => e.AdminId);

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.HasOne(e => e.MovieData)
                      .WithMany()
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.UserData)
                      .WithMany(u => u.Bookings)
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.ShowData)
                      .WithMany()
                      .HasForeignKey(e => e.ShowId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.TheatreData)
                      .WithMany(t => t.Bookings)
                      .HasForeignKey(e => e.TheaterId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.TicketData)
                      .WithMany(t => t.Bookings)
                      .HasForeignKey(e => e.TicketId)
                      .OnDelete(DeleteBehavior.Restrict); 
            });


            modelBuilder.Entity<City>().HasKey(e => e.CityId);
            modelBuilder.Entity<Genre>().HasKey(e => e.GenreId);
            modelBuilder.Entity<Language>().HasKey(e => e.LanguageId);

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.HasOne(e => e.GenreData)
                      .WithMany(g => g.Movies)
                      .HasForeignKey(e => e.GenreId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasOne(e => e.UserData)
                      .WithMany(u => u.Reviews)
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.MovieData)
                      .WithMany()
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity.HasKey(e => e.SeatId);

                entity.HasOne(e => e.TheatreData)
                      .WithMany()
                      .HasForeignKey(e => e.TheatreId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.HasKey(e => e.ShowId);

                entity.HasOne(e => e.MovieData)
                      .WithMany()
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.TheatreData)
                      .WithMany(t => t.ShowTimes)
                      .HasForeignKey(e => e.TheatreId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Theatre>(entity =>
            {
                entity.HasKey(e => e.TheatreId);

                entity.HasOne(e => e.CityData)
                      .WithMany()
                      .HasForeignKey(e => e.CityId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.HasOne(e => e.UserData)
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.MovieData)
                      .WithMany()
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.TheatreData)
                      .WithMany()
                      .HasForeignKey(e => e.TheaterId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.SeatData)
                      .WithMany()
                      .HasForeignKey(e => e.SeatNumbers)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.ShowData)
                      .WithMany()
                      .HasForeignKey(e => e.ShowId)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<User>().HasKey(e => e.UserId);

            modelBuilder.Entity<MovieLanguage>(entity =>
            {
                entity.HasKey(e => e.MovieLanguageId);

                entity.HasOne(e => e.MovieData)
                      .WithMany()
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Language)
                      .WithMany()
                      .HasForeignKey(e => e.LanguageId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}