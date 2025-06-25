using System.ComponentModel.DataAnnotations;

namespace RideAggrigationAPI.DTO
{
    public class LocationDTO
    {
        public Guid LocationId { get; set; }
       
        public string LocationName { get; set; }
    }
    public class LocationAddDTO
    {
        public Guid LocationId { get; set; }

        public string LocationName { get; set; }
    }

}
