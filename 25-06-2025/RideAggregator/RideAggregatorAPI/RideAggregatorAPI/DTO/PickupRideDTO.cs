namespace RideAggregatorAPI.DTO
{
    public class PickupRideDTO
    {
        public Guid PickupRideId { get; set; }
        public Guid SourceLocation { get; set; }
        public Guid DestinationLocation { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }

    }
}
