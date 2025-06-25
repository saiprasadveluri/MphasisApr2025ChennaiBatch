using System.ComponentModel.DataAnnotations;

namespace RideAggregatorApp.Model
{
    public class Location
    {
        [Key]
        public Guid LId { get; set; }
        [Required]
        public string LName { get; set; }

        public ICollection<PicknDrop> PickupLocationRides { get; set;}
        public ICollection<PicknDrop>DropLocationRide { get; set;}  

    }
}
