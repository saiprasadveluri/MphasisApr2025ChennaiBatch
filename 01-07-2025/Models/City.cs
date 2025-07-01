using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("City")]
public partial class City
{
    [Key]
    [Column("CityID")]
    public int CityId { get; set; }

    [StringLength(100)]
    public string CityName { get; set; } = null!;

    [InverseProperty("City")]
    public virtual ICollection<TheaterName> TheaterNames { get; set; } = new List<TheaterName>();

    [InverseProperty("City")]
    public virtual ICollection<Theater> Theaters { get; set; } = new List<Theater>();
}
