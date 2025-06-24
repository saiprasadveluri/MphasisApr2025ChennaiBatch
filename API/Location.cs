using System.ComponentModel.DataAnnotations;

namespace RideAppApi
{
    public class Location
    {
        [Key]
        public int LocationId {  get; set; }
        public string? LocationName { get; set; }

        //public ICollection<PickUpDrop> PickLoc { get; set; }
        //public ICollection<PickUpDrop> DropLoc { get; set; }
    }
}
