using System.ComponentModel.DataAnnotations;

namespace RideAPPMVC.Models
{
    public class GetAllPick
    {
        public List<PickUpDropDTO> data { get; set; } = new List<PickUpDropDTO>();
    }
    public class PickUpDropDTO
    {
     
            public int pId { get; set; }
            public int driverId { get; set; } 
            public int custId { get; set; }
            public int pickLocId { get; set; }
            public int dropLocId { get; set; }
            public DateTime pickUpTime { get; set; }
            public DateTime dropTime { get; set; }
        }
    }


