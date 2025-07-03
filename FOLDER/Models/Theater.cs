using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Theater")]
public partial class Theater
{
    [Key]
    [Column("TID")]
    public int Tid { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Column("CityID")]
    public int? CityId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Price { get; set; }

    public int? NoOfSeats { get; set; }

    [Column("MovieID")]
    public int? MovieId { get; set; }

    [InverseProperty("TidNavigation")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [ForeignKey("CityId")]
    [InverseProperty("Theaters")]
    public virtual City? City { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Theaters")]
    public virtual Movie? Movie { get; set; }

    [InverseProperty("Theater")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("Theater")]
    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    [InverseProperty("Theater")]
    public virtual ICollection<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();

    [InverseProperty("Theater")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
