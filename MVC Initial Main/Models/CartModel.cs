namespace OnlinePharmacyAppMVC.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int MedicineId { get; set; }
        public string MedName { get; set; }
        public int StockQty { get; set; }
        public int AvailableQty { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
