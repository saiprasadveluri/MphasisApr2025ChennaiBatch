using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.DataAnnotations;

namespace RideAggregatorApp.Model
{
    public class PicknDrop
    {
        [Key]
        public Guid RideId { get; set; }    
        [Required]
        public string RideTime { get; set; }
        [Required]
        public decimal  Fare{ get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public Guid DriveId { get; set; }   
        [Required]
        public Guid PickupLocationId { get; set; }  
        
        public Guid DropLocationId { get; set; }
        //Navigation 
        public Customer Customer { get; set; }  
        public Driver Driver { get; set; }
        public Location PickupLocation { get; set; }
        public Location DropLocation { get; set; }

          
        
       

    }
}
