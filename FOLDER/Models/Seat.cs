using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Seat")]
public partial class Seat
{
    [Key]
    [Column("SeatID")]
    public int SeatId { get; set; }

    [StringLength(50)]
    public string SeatNumber { get; set; } = null!;

    [Column("TheaterID")]
    public int? TheaterId { get; set; }

    [InverseProperty("Seat")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("TheaterId")]
    [InverseProperty("Seats")]
    public virtual Theater? Theater { get; set; }

    [InverseProperty("Seat")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
