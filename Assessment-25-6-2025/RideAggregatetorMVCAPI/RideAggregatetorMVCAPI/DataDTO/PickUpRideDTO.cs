namespace RideAggregatetorMVCAPI.DataDTO
{
    public class PickUpRideDTO
    {
        public Guid pickUpRideId { get; set; }
        public Guid sourceLoc { get; set; }
        public Guid destinationLoc { get; set; }
        public Guid driverId { get; set; }
        public Guid customerId { get; set; }
        public int price { get; set; }
    }
}
