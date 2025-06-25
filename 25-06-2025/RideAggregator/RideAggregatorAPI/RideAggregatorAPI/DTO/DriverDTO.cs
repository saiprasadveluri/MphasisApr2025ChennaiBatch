namespace RideAggregatorAPI.DTO
{
    public class DriverDTO
    {
        public Guid DriverId { get; set; }
        public Guid UserId { get; set; }
        public string DriverName { get; set; }
        public string DriverRating { get; set; }
    }
}
