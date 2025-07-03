namespace OnlinePharmacyAppAPI.DTO
{
    public class CartSummaryDTO
    {
        public List<CartDTO> CartItems { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalTotal { get; set; }
        public string AppliedDiscountCode { get; set; }
    }

}