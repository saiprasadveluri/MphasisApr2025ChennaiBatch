namespace RideAggregatorAPI.DTO
{
    public class CustomerDTO
    {
        public Guid CustomerId { get; set; }
        public Guid UserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
    }
}
