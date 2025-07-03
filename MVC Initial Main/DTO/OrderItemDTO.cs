namespace OnlinePharmacyAppMVC.DTO
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
    public class GetOrderItem
    {
        public List<OrderItemDTO> data { get; set; }

    }
}
