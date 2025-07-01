using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Admin")]
public partial class Admin
{
    [Key]
    public int AdminId { get; set; }

    [StringLength(50)]
    public string Username { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    [StringLength(20)]
    public string EnableEdit { get; set; }
}
