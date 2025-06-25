namespace RideUI.DTO
{
    public class GetRent
    {
        public List<RentalRideDTO> result { get; set; } = new List<RentalRideDTO>();
    }
    public class RentalRideDTO
    {
        public Guid rentalId { get; set; }
        public double distance { get; set; }
        public int hiredDays { get; set; }
        public Guid custId { get; set; }
        public Guid driverId { get; set; }
    }
}
