using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAppApi
{
    public class PickUpDrop
    {
        [Key]
        public int PId { get; set; }


        public  int DriverId { get; set; }
        //[ForeignKey(nameof(DriverId))]
        //public Driver? Driver { get; set; }


        public int CustId { get; set; }
        //[ForeignKey(nameof(CustId))]
        //public Customer? Customer { get; set; }


        public int PickLocId { get; set; }
        //[ForeignKey(nameof(PickLocId))]
        //public Location? PickLocation { get; set; }


        public int DropLocId { get; set; }
        //[ForeignKey(nameof(DropLocId))]
        //public Location? DropLocation { get; set; }


        public DateTime PickUpTime { get; set; }
        public DateTime DropTime { get; set; }
    }
}
