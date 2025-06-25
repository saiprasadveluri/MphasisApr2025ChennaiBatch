using System.ComponentModel.DataAnnotations;

namespace RideAggrigationAPI.Data
{
    public class Location
    {
        [Key]
        [Required]
        public Guid LocationId {  get; set; }
        [Required]
        public string LocationName { get; set; }
    }
}
