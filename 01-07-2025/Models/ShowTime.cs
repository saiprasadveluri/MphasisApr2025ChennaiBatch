using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("ShowTime")]
public partial class ShowTime
{
    [Key]
    [Column("show_id")]
    public int ShowId { get; set; }

    [Column("MovieID")]
    public int? MovieId { get; set; }

    [Column("timings")]
    [StringLength(50)]
    [Unicode(false)]
    public string Timings { get; set; }

    [Column("TheaterID")]
    public int? TheaterId { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("ShowTimes")]
    public virtual Movie Movie { get; set; }

    [ForeignKey("TheaterId")]
    [InverseProperty("ShowTimes")]
    public virtual Theater Theater { get; set; }

    [InverseProperty("Show")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("Show")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
