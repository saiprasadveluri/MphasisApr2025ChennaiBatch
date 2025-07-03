namespace OnlinePharmacyAppMVC.DTO
{
    public class DiscountDTO
    {
        public string DiscountCode { get; set; }
        public string DiscountType { get; set; }
        public decimal Value { get; set; }
        public bool IsPercentage { get; set; }
    }
}
