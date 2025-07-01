namespace OnlinePharmacyAppMVC.DTO
{
    public class CartItemDTO
    {
        public int MedicineId { get; set; }
        public string MedName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

}
