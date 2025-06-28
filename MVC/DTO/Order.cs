namespace OnlinePharmacyApp.DTO
{
  
        public class GetOrder
        {
            public List<OrderDTO> data { get; set; }

        }
        public class OrderDTO
        {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateOnly OrderDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public decimal TotalAmount { get; set; }
        public bool IsFirstOrder { get; set; } = true;
        public decimal Price { get; set; } = 0;
        public string Status { get; set; }
    }


}
    
