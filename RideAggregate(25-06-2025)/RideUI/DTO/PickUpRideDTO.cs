namespace RideUI.DTO
{
    public class GetPickUp
    {
        public List<PickUpRideDTO> result { get; set; }=new List<PickUpRideDTO>();
    }
    public class PickUpRideDTO
    {
        public Guid pickId { get; set; }

        public Guid sourceLoc { get; set; }

        public Guid destinationLoc { get; set; }

        public Guid custId { get; set; }

        public Guid driverId { get; set; }
    }
}
