namespace OnlinePharmacyAppAPI.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateOnly OrderDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public decimal TotalAmount { get; set; }
        public bool IsFirstOrder { get; set; } = true;
        public decimal DiscountApplied { get; set; } = 0;
        public int? DiscountId { get; set; }
        public string Status { get; set; }
    }
}
