using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.DTO
{
    public class RentalDTO
    {
        public Guid RentalId { get; internal set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SourceLocationid { get; set; }
        public Guid DistinationLocationid { get; set; }

    }
    public class RentalAddDTO
    {
        public Guid RentalId { get; set; } 
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SourceLocationid { get; set; }
        public Guid DistinationLocationid { get; set; }

    }


}
