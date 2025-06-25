namespace RideAggregatorMVC.MVCDTO
{
    public class DriverDTO
    {
        public Guid driverId { get; set; }
        public string driverName { get; set; }
    }
    public class GetDrivers
    {
        public List<DriverDTO> data { get; set; }
    }
}
