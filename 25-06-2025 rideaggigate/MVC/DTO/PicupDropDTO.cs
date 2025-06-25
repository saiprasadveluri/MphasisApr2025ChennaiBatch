using RideAggrigationAPI.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.DTO
{
    public class PicupDropDTO
    {

        public Guid PickupDropId { get; set; }    
        public int numofdays { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SourceLocationid { get; set; }
        public Guid DistinationLocationid { get; set; }
    }
    public class PicupDropAddDTO
    {

        public Guid PickupDropId { get; set; }
        public int numofdays { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DriverId { get; set; }
        public Guid SourceLocationid { get; set; }
        public Guid DistinationLocationid { get; set; }
    }



}
