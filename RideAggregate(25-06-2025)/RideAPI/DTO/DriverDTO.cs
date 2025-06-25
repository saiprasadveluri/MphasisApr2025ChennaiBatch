using RideAPI.Data;

namespace RideAPI.DTO
{
    public class DriverDTO
    {
        public Guid DriverId { get; set; }
        public Guid UserId { get; set; }
        public string DriverName { get; set; }
        public double DriverRating { get; set; }
    }
}
