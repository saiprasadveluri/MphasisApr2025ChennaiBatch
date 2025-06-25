using System.ComponentModel.DataAnnotations;

namespace RideAggregatorWEBAPI.Data
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public string LocationName { get; set; }
    }
}
