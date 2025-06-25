using System.ComponentModel.DataAnnotations;

namespace RideAggregatorApp.Model
{
    public class Customer
    {
        [Key]
        public Guid CustId { get; set; }

        [Required]
        public string CustName { get; set; }
        [Required]
        public string CustPhone { get; set; } 
        [Required]
        public string Email { get; set; } 

        //navigation

        public ICollection<PicknDrop>PicknDrops { get; set; } 
        public ICollection<Rental>Rentals { get; set; }
        

    }
}

