namespace OnlinePharmacyAppMVC.DTO
{
    public class OrderDTO
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public DateOnly orderDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public decimal totalAmount { get; set; }
        public bool isFirstOrder { get; set; } = true;
        public decimal price { get; set; } = 0;
        public string status { get; set; }
    }
    public class GetOrder
    {
        public List<OrderDTO> data { get; set; }

    }
}
