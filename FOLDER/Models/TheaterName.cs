using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("TheaterName")]
public partial class TheaterName
{
    [Key]
    public int Theaternameid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Theatername1 { get; set; } = null!;

    public int? CityId { get; set; }

    [ForeignKey("CityId")]
    [InverseProperty("TheaterNames")]
    public virtual City? City { get; set; }
}
