using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Movie")]
public partial class Movie
{
    [Key]
    [Column("MovieID")]
    public int MovieId { get; set; }

    [StringLength(100)]
    public string MovieName { get; set; } = null!;

    [Column("GenreID")]
    public int? GenreId { get; set; }

    [StringLength(50)]
    public string? Duration { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public byte[]? MoviePoster { get; set; }

    [InverseProperty("Movie")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [ForeignKey("GenreId")]
    [InverseProperty("Movies")]
    public virtual Genre? Genre { get; set; }

    [InverseProperty("Movie")]
    public virtual ICollection<MovieCast> MovieCasts { get; set; } = new List<MovieCast>();

    [InverseProperty("Movie")]
    public virtual ICollection<MovieLanguage> MovieLanguages { get; set; } = new List<MovieLanguage>();

    [InverseProperty("Movie")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("Movie")]
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    [InverseProperty("Movie")]
    public virtual ICollection<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();

    [InverseProperty("Movie")]
    public virtual ICollection<Theater> Theaters { get; set; } = new List<Theater>();

    [InverseProperty("Movie")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
