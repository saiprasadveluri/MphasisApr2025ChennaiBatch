using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyApp.DTO
{
    public class Discount
    {
        public int discountId { get; set; }

        [Required, StringLength(50)]
        public string discountCode { get; set; }

        [Required]
        public string discountType { get; set; }

        [Required]
        public decimal value { get; set; }

        [Required]
        public bool isPercentage { get; set; } = true;

        public DateTime startDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
