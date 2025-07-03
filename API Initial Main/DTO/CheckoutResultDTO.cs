namespace OnlinePharmacyAppAPI.DTO
{
    public class CheckoutResultDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public decimal FinalAmount { get; set; }
    }
}
