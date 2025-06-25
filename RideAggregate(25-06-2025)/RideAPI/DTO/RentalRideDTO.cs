using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.DTO
{
    public class RentalRideDTO
    {
        public Guid RentalId { get; set; }
        public double Distance { get; set; }
        public int HiredDays { get; set; }
        public Guid CustId { get; set; }
        public Guid DriverId { get; set; }
    }
}
