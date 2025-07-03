using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.DTO
{
    public class DiscountDTO
    {
        public int DiscountId { get; set; }
        public int UserId { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountType { get; set; }
        public decimal Value { get; set; }
        public bool IsPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

}