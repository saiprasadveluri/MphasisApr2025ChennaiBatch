using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.DTO
{
    public class DiscountDTO
    {
        public int DiscountId { get; set; }

        
        public string DiscountCode { get; set; }

  
        public string DiscountType { get; set; }

  
        public decimal Value { get; set; }

 
        public bool IsPercentage { get; set; } = true;

        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; }
    }
}
