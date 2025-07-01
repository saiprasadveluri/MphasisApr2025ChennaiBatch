using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public DateOnly OrderDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public decimal TotalAmount { get; set; }
        public bool IsFirstOrder { get; set; }=true;
        public decimal DiscountApplied { get; set; } = 0;
        [ForeignKey(nameof(Discount))]
        public int? DiscountId { get; set; }
        public string Status { get; set; }

        //Navigation
        public User User { get; set; }
        public Discount Discount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
