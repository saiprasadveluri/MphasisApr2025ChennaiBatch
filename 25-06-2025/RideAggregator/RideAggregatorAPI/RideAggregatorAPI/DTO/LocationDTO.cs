using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.DTO
{
    public class LocationDTO
    {
      
        public Guid LocId { get; set; }

        public string LocName { get; set; }

    }
}

