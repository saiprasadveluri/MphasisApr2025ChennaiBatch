using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Payment")]
public partial class Payment
{
    [Key]
    [Column("pid")]
    public int Pid { get; set; }

    public int? Ticketid { get; set; }

    [Column("show_id")]
    public int? ShowId { get; set; }

    [Column("status")]
    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column("payment_type")]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentType { get; set; } = null!;

    [Column("total_amount", TypeName = "decimal(10, 2)")]
    public decimal TotalAmount { get; set; }

    [Column("payment_date", TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column("Theater_id")]
    public int TheaterId { get; set; }

    [Column("Movie_id")]
    public int MovieId { get; set; }

    [Column("Seat_id")]
    public int SeatId { get; set; }

    [StringLength(50)]
    public string? SeatNumber { get; set; }

    [InverseProperty("PidNavigation")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [InverseProperty("PidNavigation")]
    public virtual Card? Card { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Payments")]
    public virtual Movie Movie { get; set; } = null!;

    [ForeignKey("SeatId")]
    [InverseProperty("Payments")]
    public virtual Seat Seat { get; set; } = null!;

    [ForeignKey("ShowId")]
    [InverseProperty("Payments")]
    public virtual ShowTime? Show { get; set; }

    [ForeignKey("TheaterId")]
    [InverseProperty("Payments")]
    public virtual Theater Theater { get; set; } = null!;

    [ForeignKey("Ticketid")]
    [InverseProperty("Payments")]
    public virtual Ticket? Ticket { get; set; }

    [InverseProperty("PidNavigation")]
    public virtual Upi? Upi { get; set; }
}
