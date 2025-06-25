using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RideAppAgg
{
    public class Location
    {
        [Key]
        public int LId { get; set; }
        public string? LName { get; set; }  // Location name

    
        //public ICollection<PickupDrop>? PickD { get; set; }

       
        //public ICollection<PickupDrop>? DropD { get; set; }


    }
}
