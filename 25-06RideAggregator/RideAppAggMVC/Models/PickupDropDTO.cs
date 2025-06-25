namespace RideAppAggMVC.Models
{
    public class GetAllPickupDrop
    {
        public List<PickupDropDTO> data { get; set; } 
    }

    public class PickupDropDTO
    {
        public int pId { get; set; } 
        public int dId { get; set; } 
       
        public int cId { get; set; } 
        public int pickupLocationId { get; set; } 
        public int dropLocationId { get; set; } 
        public DateTime pickupTime { get; set; } 
        public DateTime dropTime { get; set; } 

    }
}
