namespace RideAggregatorAPI.DTO
{
    public class DriverDTO
    {
        public Guid Id { get; set; }
        public Guid LoginId { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
