using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregators.DTO
{
    public class DriverDTO
    {
        public Guid DriverId { get; set; }
       
        public Guid LoginId { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string DriverName { get; set; }
    }
}
