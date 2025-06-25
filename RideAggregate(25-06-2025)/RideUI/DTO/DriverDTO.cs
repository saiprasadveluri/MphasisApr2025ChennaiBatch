namespace RideUI.DTO
{
    public class GetDriver
    {
        public List<DriverDTO> result { get; set; }=new List<DriverDTO>();
    }
    public class DriverDTO
    {
        public Guid driverId { get; set; }
        public Guid userId { get; set; }
        public string driverName { get; set; }
        public double driverRating { get; set; }
    }
}
