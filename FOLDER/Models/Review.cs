using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Review")]
public partial class Review
{
    [Key]
    [Column("ReviewID")]
    public int ReviewId { get; set; }

    public int? Uid { get; set; }

    [Column("MovieID")]
    public int? MovieId { get; set; }

    public int? Rating { get; set; }

    [StringLength(255)]
    public string? CommentText { get; set; }

    public int? Like { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Reviews")]
    public virtual Movie? Movie { get; set; }

    [ForeignKey("Uid")]
    [InverseProperty("Reviews")]
    public virtual User? UidNavigation { get; set; }
}
