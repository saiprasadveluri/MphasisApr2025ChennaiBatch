namespace RideAggregatorAPI.DTO
{
    public class RentalRideDTO
    {
        public Guid RentalId { get; set; }
        public double Distance { get; set; }
        public int HiredDays { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
    }
}
