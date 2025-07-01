using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models;

[Table("Card")]
[Index("Pid", Name = "UQ__Card__DD37D91B8E2848FD", IsUnique = true)]
public partial class Card
{
    [Key]
    [Column("card_payment_id")]
    public int CardPaymentId { get; set; }

    [Column("pid")]
    public int Pid { get; set; }

    [Column("card_number_masked")]
    [StringLength(20)]
    [Unicode(false)]
    public string CardNumberMasked { get; set; } = null!;

    [Column("card_holder_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string CardHolderName { get; set; } = null!;

    [Column("expiry_month")]
    [StringLength(2)]
    [Unicode(false)]
    public string ExpiryMonth { get; set; } = null!;

    [Column("expiry_year")]
    [StringLength(4)]
    [Unicode(false)]
    public string ExpiryYear { get; set; } = null!;

    [Column("card_type")]
    [StringLength(10)]
    [Unicode(false)]
    public string CardType { get; set; } = null!;

    [Column("card_cvv")]
    [StringLength(3)]
    [Unicode(false)]
    public string CardCvv { get; set; } = null!;

    [Column("transaction_id")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    [Column("payment_timestamp", TypeName = "datetime")]
    public DateTime? PaymentTimestamp { get; set; }

    [ForeignKey("Pid")]
    [InverseProperty("Card")]
    public virtual Payment PidNavigation { get; set; } = null!;
}
