namespace RideAppAggMVC.Models
{

    public class GetAllRides
    {
        public List<RideDTO> data { get; set; } // List of RideDTO objects representing all rides
    }
    public class RideDTO
    {
        public int rId { get; set; } 
        public int pId { get; set; }
       
        public double distance { get; set; }
        public double costPerKm { get; set; }
    }
}
