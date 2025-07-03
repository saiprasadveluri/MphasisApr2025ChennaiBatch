using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Ticket")]
public partial class Ticket
{
    [Key]
    public int Ticketid { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("MovieID")]
    public int? MovieId { get; set; }

    [Column("ShowID")]
    public int? ShowId { get; set; }

    [Column("SeatID")]
    public int? SeatId { get; set; }

    [Column("TheaterID")]
    public int? TheaterId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TicketDate { get; set; }

    [NotMapped]
    public string? SeatNumbers { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Tickets")]
    public virtual Movie? Movie { get; set; }

    [InverseProperty("Ticket")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [InverseProperty("Ticket")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("SeatId")]
    [InverseProperty("Tickets")]
    public virtual Seat? Seat { get; set; }

    [ForeignKey("ShowId")]
    [InverseProperty("Tickets")]
    public virtual ShowTime? Show { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Tickets")]
    public virtual User? User { get; set; }

    [ForeignKey("TheaterId")]
    [InverseProperty("Tickets")]
    public virtual Theater? Theater { get; set; }
}
