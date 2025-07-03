namespace OnlinePharmacyAppMVC.DTO
{
    public class CartSummaryDTO
    {
        public List<CartItemDTO> CartItems { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalTotal { get; set; }
        public string AppliedDiscountCode { get; set; }
    }
}
