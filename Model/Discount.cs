using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.Model
{
    public class Discount
    {
        public int DiscountId { get; set; }

        [Required, StringLength(50)]
        public string DiscountCode { get; set; }

        [Required]
        public string DiscountType { get; set; } 

        [Required]
        public decimal Value { get; set; } 

        [Required]
        public bool IsPercentage { get; set; } = true;

        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
