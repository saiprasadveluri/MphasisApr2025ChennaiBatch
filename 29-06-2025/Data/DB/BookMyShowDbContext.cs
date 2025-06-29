using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; // Ensure this is present for ICollection types

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
        public virtual DbSet<MovieShow> MovieShows { get; set; } // **Crucial: Added DbSet for MovieShow**

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Admin
            modelBuilder.Entity<Admin>().HasKey(e => e.AdminId);

            // Booking
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                // Booking (Many) to User (One)
                entity.HasOne(e => e.UserData)
                      .WithMany(u => u.Bookings) // User has a collection of Bookings
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting user if they have bookings

                // Booking (Many) to MovieShow (One) - This is the core link to the specific showing
                entity.HasOne(e => e.MovieShowData)
                      .WithMany(ms => ms.Bookings) // MovieShow has a collection of Bookings
                      .HasForeignKey(e => e.MovieShowId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting MovieShow if bookings exist for it

                // Booking (One) to Ticket (Many) - Configured from Ticket side for FK, but InverseProperty from Booking
                entity.HasMany(e => e.Tickets)
                      .WithOne(t => t.BookingData) // Ticket has one BookingData
                      .HasForeignKey(t => t.BookingId)
                      .OnDelete(DeleteBehavior.Cascade); // If booking is deleted, its tickets are also deleted
            });

            // City
            modelBuilder.Entity<City>().HasKey(e => e.CityId);
            modelBuilder.Entity<City>()
                .HasMany(c => c.Theatres) // City has many Theatres
                .WithOne(t => t.CityData) // Theatre has one CityData
                .HasForeignKey(t => t.CityId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deleting city if theatres exist in it

            // Genre
            modelBuilder.Entity<Genre>().HasKey(e => e.GenreId);
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Movies) // Genre has many Movies
                .WithOne(m => m.GenreData) // Movie has one GenreData
                .HasForeignKey(m => m.GenreId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deleting genre if movies exist in it

            // Language
            modelBuilder.Entity<Language>().HasKey(e => e.LanguageId);
            modelBuilder.Entity<Language>()
                .HasMany(l => l.MovieLanguages) // Language has many MovieLanguages (in the join table)
                .WithOne(ml => ml.Language)     // MovieLanguage has one Language
                .HasForeignKey(ml => ml.LanguageId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deleting language if movies are linked to it

            // Movie
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                // Movie (One) to Review (Many)
                entity.HasMany(e => e.Reviews)
                      .WithOne(r => r.MovieData)
                      .HasForeignKey(r => r.MovieId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting movie if reviews exist for it

                // Movie (One) to MovieLanguage (Many) - for the many-to-many join
                entity.HasMany(e => e.MovieLanguages)
                      .WithOne(ml => ml.MovieData)
                      .HasForeignKey(ml => ml.MovieId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting movie if it has language associations

                // Movie (One) to MovieShow (Many)
                entity.HasMany(e => e.MovieShows)
                      .WithOne(ms => ms.Movie) // MovieShow has one Movie
                      .HasForeignKey(ms => ms.MovieId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting movie if it has shows scheduled
            });

            // MovieLanguage (Join table for Many-to-Many between Movie and Language)
            modelBuilder.Entity<MovieLanguage>(entity =>
            {
                entity.HasKey(e => e.MovieLanguageId);

                entity.HasOne(e => e.MovieData)
                      .WithMany(m => m.MovieLanguages) // Movie has many MovieLanguages
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Cascade); // If movie is deleted, remove its language links

                entity.HasOne(e => e.Language)
                      .WithMany(l => l.MovieLanguages) // Language has many MovieLanguages
                      .HasForeignKey(e => e.LanguageId)
                      .OnDelete(DeleteBehavior.Cascade); // If language is deleted, remove its movie links
            });

            // MovieShow (Junction table linking a Movie to a specific Show at a specific Theatre)
            modelBuilder.Entity<MovieShow>(entity =>
            {
                entity.HasKey(e => e.MovieShowId);

                // MovieShow (Many) to Movie (One)
                entity.HasOne(e => e.Movie)
                      .WithMany(m => m.MovieShows) // Movie has a collection of MovieShows
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Restrict);

                // MovieShow (Many) to Show (One)
                entity.HasOne(e => e.Show)
                      .WithMany(s => s.MovieShows) // Show has a collection of MovieShows
                      .HasForeignKey(e => e.ShowId)
                      .OnDelete(DeleteBehavior.Restrict);

                // MovieShow (Many) to Theatre (One)
                entity.HasOne(e => e.Theatre)
                      .WithMany(t => t.MovieShows) // Theatre has a collection of MovieShows
                      .HasForeignKey(e => e.TheatreId)
                      .OnDelete(DeleteBehavior.Restrict);

                // MovieShow (One) to Booking (Many) - configured from Booking side
            });

            // Review
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                // Review (Many) to User (One)
                entity.HasOne(e => e.UserData)
                      .WithMany(u => u.Reviews)
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting user if they have reviews

                // Review (Many) to Movie (One)
                entity.HasOne(e => e.MovieData)
                      .WithMany(m => m.Reviews) // Movie has a collection of Reviews
                      .HasForeignKey(e => e.MovieId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting movie if it has reviews
            });

            // Seat
            modelBuilder.Entity<Seat>(entity =>
            {
                entity.HasKey(e => e.SeatId);

                // Seat (Many) to Theatre (One)
                entity.HasOne(e => e.TheatreData)
                      .WithMany(t => t.Seats) // Theatre has a collection of Seats
                      .HasForeignKey(e => e.TheatreId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting theatre if it has seats

                // Seat (One) to Ticket (Many) - configured from Ticket side
            });

            // Show (Represents a general time slot in a theatre)
            modelBuilder.Entity<Show>(entity =>
            {
                entity.HasKey(e => e.ShowId);

                // Show (Many) to Theatre (One)
                entity.HasOne(e => e.TheatreData)
                      .WithMany(t => t.Shows) // Theatre has a collection of Shows (time slots)
                      .HasForeignKey(e => e.TheatreId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting theatre if it has show times

                // Show (One) to MovieShow (Many) - configured from MovieShow side
            });

            // Theatre
            modelBuilder.Entity<Theatre>(entity =>
            {
                entity.HasKey(e => e.TheatreId);

                // Theatre (Many) to City (One) - configured from City side
                // Relationships to Shows, Seats, MovieShows are also configured from their respective entities.
            });

            // Ticket
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                // Ticket (Many) to Booking (One) - configured from Booking side
                // Ticket (Many) to Seat (One)
                entity.HasOne(e => e.SeatData)
                      .WithMany(s => s.Tickets) // Seat has a collection of Tickets
                      .HasForeignKey(e => e.SeatId)
                      .OnDelete(DeleteBehavior.Restrict); // Prevent deleting seat if tickets are associated with it
            });

            // User
            modelBuilder.Entity<User>().HasKey(e => e.UserId);
            // Relationships to Bookings and Reviews are configured from Booking and Review entities
        }
    }
}