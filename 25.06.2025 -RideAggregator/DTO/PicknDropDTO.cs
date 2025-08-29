namespace RideAggregatorApp.DTO
{
    public class PicknDropDTO
    {
        public Guid RideId { get; set; }
        public DateTime RideTime { get; set; }
        public decimal Fare { get; set; }
            public Guid CustomerId { get; set; }
        public Guid  DriverId { get; set; }
          public Guid PickupLocationId { get; set; }
        public Guid  DropLocationId  { get; set; }



    }
}
