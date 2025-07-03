using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("MovieCast")]
public partial class MovieCast
{
    [Column("MovieID")]
    public int? MovieId { get; set; }

    [Key]
    [Column("CID")]
    public int Cid { get; set; }

    [StringLength(100)]
    public string? Actor { get; set; }

    [StringLength(100)]
    public string? Actress { get; set; }

    [StringLength(100)]
    public string? Director { get; set; }

    [StringLength(100)]
    public string? Producer { get; set; }

    [StringLength(100)]
    public string? Musician { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("MovieCasts")]
    public virtual Movie? Movie { get; set; }
}
