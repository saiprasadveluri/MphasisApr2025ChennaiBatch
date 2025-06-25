using System.ComponentModel.DataAnnotations;

namespace RiderApp.Models
{
    public class Customer
    {
        [Key]
        public Guid CustId {  get; set; }
        [Required]
        public string CustName { get; set; }
        [Required]
        public string CustPhone { get; set; }
        [Required]
        public string Email { get; set; }
        // Navigation
        public ICollection<PicknDrop> PicknDrops { get; set; }
        public ICollection<Rental> Rentals { get; set; }



    }
}
