using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RideAppAgg
{
    public class Driver
    {
        [Key]
        public int DId { get; set; }
        public int UId { get; set; } // Foreign key to the User table
        //[ForeignKey(nameof(UId))]
        //public User User { get; set; } // Navigation property to User entity

        public string? DName { get; set; }  
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int Rating { get; set; }
        public int NoOfRides { get; set; }
        


       
       

        //public ICollection<PickupDrop> pickDs { get; set; }
       
        
    }
}
