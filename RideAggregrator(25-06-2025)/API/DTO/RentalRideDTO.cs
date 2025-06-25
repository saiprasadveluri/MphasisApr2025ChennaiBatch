namespace RideAggerator.DTO
{
    public class RentalRideDTO
    {
        public Guid RetalRideId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SourceId { get; set; }
        public double Distance { get; set; }
        public int HiredDays { get; set; }
    }
}
