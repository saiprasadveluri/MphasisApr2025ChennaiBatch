using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Booking")]
public partial class Booking
{
    [Key]
    [Column("BookID")]
    public int BookId { get; set; }

    public int? Pid { get; set; }

    [Column("MovieID")]
    public int? MovieId { get; set; }

    public DateOnly? BookingDate { get; set; }

    [Column("ShowID")]
    public int? ShowId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    public int? Tid { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [StringLength(50)]
    public string? SeatNumbers { get; set; }

    [StringLength(50)]
    public string? ShowTime { get; set; }

    public int? TicketId { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Bookings")]
    public virtual Movie? Movie { get; set; }

    [ForeignKey("Pid")]
    [InverseProperty("Bookings")]
    public virtual Payment? PidNavigation { get; set; }

    [ForeignKey("Tid")]
    [InverseProperty("Bookings")]
    public virtual Theater? TidNavigation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Bookings")]
    public virtual User? User { get; set; }

    [ForeignKey("TicketId")]
    [InverseProperty("Bookings")]
    public virtual Ticket? Ticket { get; set; }
}
