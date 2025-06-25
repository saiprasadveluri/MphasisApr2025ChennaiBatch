namespace RideAggerator.DTO
{
    public class PickupRideDTO
    {
        public Guid PickupId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SourceId { get; set; }
        public Guid DestinationId { get; set; }
        public double Distance { get; set; }
    }
}
