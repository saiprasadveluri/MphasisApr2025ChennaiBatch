namespace RideAggregateMVCAPI.DTO
{
    public class DriverDTOM
    {
        public Guid driverId { get; set; }

        public Guid loginId { get; set; }

        public string phoneNumber { get; set; }
        public string driverName { get; set; }
        public string vehicleName { get; set; }
        public string vehicleNo { get; set; }
    }
    public class GetAllDrivers()
    {
        public List<DriverDTOM> data { get; set; } = new List<DriverDTOM>();
    }
}
