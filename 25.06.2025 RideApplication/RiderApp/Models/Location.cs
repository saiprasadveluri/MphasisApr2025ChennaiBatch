using System.ComponentModel.DataAnnotations;

namespace RiderApp.Models
{
    public class Location
    {
        [Key]
        public Guid LId { get; set; }
        [Required]
        public string LName { get; set; }

        public ICollection<PicknDrop> PickupLocationRides { get; set; }
        public ICollection<PicknDrop> DropLocationRides { get; set; }

    }
}
