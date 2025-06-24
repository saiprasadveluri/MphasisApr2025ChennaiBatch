using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideAggregateAPI.DTO
{
    public class DriversDTO
    {
        
        public Guid DriverId { get; set; }
       
        public Guid LoginId { get; set; }
        
        public string PhoneNumber { get; set; }
        public string DriverName { get; set; }
        public string VehicleName { get; set; }
        public string VehicleNo { get; set; }
    }
}
