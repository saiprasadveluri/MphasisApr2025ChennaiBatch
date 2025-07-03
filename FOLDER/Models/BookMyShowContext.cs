using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

public partial class BookMyShowContext : DbContext
{
    public BookMyShowContext()
    {
    }

    public BookMyShowContext(DbContextOptions<BookMyShowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Booking> Bookings { get; set; }
    public virtual DbSet<Card> Cards { get; set; }
    public virtual DbSet<City> Cities { get; set; }
    public virtual DbSet<Genre> Genres { get; set; }
    public virtual DbSet<Language> Languages { get; set; }
    public virtual DbSet<Movie> Movies { get; set; }
    public virtual DbSet<MovieCast> MovieCasts { get; set; }
    public virtual DbSet<MovieLanguage> MovieLanguages { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public virtual DbSet<Seat> Seats { get; set; }
    public virtual DbSet<ShowTime> ShowTimes { get; set; }
    public virtual DbSet<Theater> Theaters { get; set; }
    public virtual DbSet<TheaterName> TheaterNames { get; set; }
    public virtual DbSet<Ticket> Tickets { get; set; }
    public virtual DbSet<Upi> Upis { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, move it out of source code.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BookMyShowDBase;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admin__719FE48843A8F0F9");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Booking__3DE0C22778E15499");

            entity.HasOne(d => d.Movie).WithMany(p => p.Bookings).HasConstraintName("FK__Booking__MovieID__59063A47");
            entity.HasOne(d => d.PidNavigation).WithMany(p => p.Bookings).HasConstraintName("FK__Booking__Pid__5812160E");
            entity.HasOne(d => d.TidNavigation).WithMany(p => p.Bookings).HasConstraintName("FK__Booking__Tid__59FA5E80");
            entity.HasOne(d => d.User).WithMany(p => p.Bookings).HasConstraintName("FK__Booking__UserID__5AEE82B9");

            entity.HasOne(d => d.Ticket).WithMany(p => p.Bookings).HasConstraintName("FK__Booking__TicketI__7E37BEF6");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.CardPaymentId).HasName("PK__Card__8800A1795B91598D");

            entity.Property(e => e.CardPaymentId).ValueGeneratedNever();
            entity.Property(e => e.CardCvv).IsFixedLength();
            entity.Property(e => e.ExpiryMonth).IsFixedLength();
            entity.Property(e => e.ExpiryYear).IsFixedLength();

            entity.HasOne(d => d.PidNavigation).WithOne(p => p.Card)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Card_Payment");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__F2D21A966C765BE5");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK__Genre__0385055EB9E2E89A");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK__Language__B938558B38A495B9");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK__Movie__4BD2943AC044950B");

            entity.HasOne(d => d.Genre).WithMany(p => p.Movies).HasConstraintName("FK__Movie__GenreID__2F10007B");
        });

        modelBuilder.Entity<MovieCast>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__MovieCas__C1F8DC59A7CEED4D");

            entity.HasOne(d => d.Movie).WithMany(p => p.MovieCasts).HasConstraintName("FK__MovieCast__Movie__33D4B598");
        });

        modelBuilder.Entity<MovieLanguage>(entity =>
        {
            entity.HasKey(e => e.Mlid).HasName("PK__MovieLan__24F4D01DD25BB54F");

            entity.HasOne(d => d.Language).WithMany(p => p.MovieLanguages).HasConstraintName("FK__MovieLang__Langu__412EB0B6");
            entity.HasOne(d => d.Movie).WithMany(p => p.MovieLanguages).HasConstraintName("FK__MovieLang__Movie__403A8C7D");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Payment__DD37D91A7F46417B");

            entity.Property(e => e.PaymentDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status).HasDefaultValue("Ongoing");
            entity.Property(e => e.SeatNumber).HasMaxLength(50).IsUnicode(false);

            entity.HasOne(d => d.Movie).WithMany(p => p.Payments).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Payment_Movie");
            entity.HasOne(d => d.Seat).WithMany(p => p.Payments).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Payment_Seat");
            entity.HasOne(d => d.Show).WithMany(p => p.Payments).HasConstraintName("FK_Payment_ShowTime");
            entity.HasOne(d => d.Theater).WithMany(p => p.Payments).HasConstraintName("FK_Payment_Theater");
            entity.HasOne(d => d.Ticket).WithMany(p => p.Payments).HasConstraintName("FK_Payment_Ticket");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Review__74BC79AE1ADB131B");

            entity.HasOne(d => d.Movie).WithMany(p => p.Reviews).HasConstraintName("FK__Review__MovieID__3B75D760");
            entity.HasOne(d => d.UidNavigation).WithMany(p => p.Reviews).HasConstraintName("FK__Review__Uid__3A81B327");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.SeatId).HasName("PK__Seat__311713D349FA4D9F");

            entity.HasOne(d => d.Theater).WithMany(p => p.Seats).HasConstraintName("FK__Seat__TheaterID__4BAC3F29");
        });

        modelBuilder.Entity<ShowTime>(entity =>
        {
            entity.HasKey(e => e.ShowId).HasName("PK__ShowTime__2B97D71C26D54598");

            entity.HasOne(d => d.Movie).WithMany(p => p.ShowTimes).HasForeignKey(d => d.MovieId).HasConstraintName("FK__ShowTime__MovieID__440B1D61");
            entity.HasOne(d => d.Theater).WithMany(p => p.ShowTimes).HasForeignKey(d => d.TheaterId).HasConstraintName("FK_ShowTime_Theater");
        });

        modelBuilder.Entity<Theater>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PK__Theater__C456D72917309CBB");

            entity.HasOne(d => d.City).WithMany(p => p.Theaters).HasConstraintName("FK__Theater__CityID__36B12243");
            entity.HasOne(d => d.Movie).WithMany(p => p.Theaters).HasConstraintName("FK__Theater__MovieID__37A5467C");
        });

        modelBuilder.Entity<TheaterName>(entity =>
        {
        entity.HasKey(e => e.Theaternameid).HasName("PK__TheaterN__46D68A3E4906DBEA");

        entity.Property(e => e.Theaternameid).ValueGeneratedNever();
            entity.HasOne(d => d.City).WithMany(p => p.TheaterNames).HasConstraintName("FK_TheaterName_City");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Ticketid).HasName("PK__Ticket__712BC23FF32737C7");

            entity.Property(e => e.TicketDate).HasColumnType("datetime");

            entity.HasOne(d => d.Movie).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK__Ticket__MovieID__47DBAE45");

            entity.HasOne(d => d.Seat).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.SeatId)
                .HasConstraintName("FK__Ticket__SeatID__4CA06362");

            entity.HasOne(d => d.Show).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ShowId)
                .HasConstraintName("FK__Ticket__ShowID__48CFD27E");

            entity.HasOne(d => d.User).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Ticket__UserID__46E78A0C");

            entity.HasOne(d => d.Theater).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.TheaterId)
                .HasConstraintName("FK_Ticket_Theater");
        });

        modelBuilder.Entity<Upi>(entity =>
        {
            entity.HasKey(e => e.UpiPaymentId).HasName("PK__UPI__3939CBB858BC924D");

            entity.Property(e => e.UpiPaymentId).ValueGeneratedNever();

            entity.HasOne(d => d.PidNavigation).WithOne(p => p.Upi)
                .HasForeignKey<Upi>(d => d.UpiPaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UPI_Payment");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCAC46926B9F");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Security_Question)
                .HasMaxLength(100)
                .HasColumnName("Security_Question");

            entity.Property(e => e.Security_Answer)
                .HasMaxLength(100)
                .HasColumnName("Security_Answer");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

