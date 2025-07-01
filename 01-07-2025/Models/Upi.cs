using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("UPI")]
[Index("Pid", Name = "UQ__UPI__DD37D91BEC73E946", IsUnique = true)]
public partial class Upi
{
    [Key]
    [Column("upi_payment_id")]
    public int UpiPaymentId { get; set; }

    [Column("pid")]
    public int Pid { get; set; }

    [Column("upi_id")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpiId { get; set; } = null!;

    [Column("transaction_id")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    [Column("payment_timestamp", TypeName = "datetime")]
    public DateTime? PaymentTimestamp { get; set; }

    [ForeignKey("Pid")]
    [InverseProperty("Upi")]
    public virtual Payment PidNavigation { get; set; } = null!;
}
