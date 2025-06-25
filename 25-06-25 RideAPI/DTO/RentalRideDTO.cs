namespace RideAggregatorAPI.DTO
{
    public class RentalRideDTO
    {
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Distance { get; set; }

    }
}
