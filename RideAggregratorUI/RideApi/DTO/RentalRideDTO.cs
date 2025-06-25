using RideApi.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideApi.DTO
{
    public class RentalRideDTO
    {
        public Guid RentalId { get; set; }
       
        public Guid CustomerId { get; set; }
       
        public Guid DriverId { get; set; }

       
        public double Distance { get; set; }
       
        public int HiredDays { get; set; }
        
    }
}
