using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("MovieLanguage")]
public partial class MovieLanguage
{
    [Key]
    public int Mlid { get; set; }

    [Column("MovieID")]
    public int? MovieId { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("MovieLanguages")]
    public virtual Language? Language { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("MovieLanguages")]
    public virtual Movie? Movie { get; set; }
}
