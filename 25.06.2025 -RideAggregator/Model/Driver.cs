using System.ComponentModel.DataAnnotations;

namespace RideAggregatorApp.Model
{
    public class Driver
    {
        [Key]
        public Guid DriverId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DriverName { get; set; }
    
        [Required]
        [Phone]
        public string PhoneNumber {  get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string LicenseNumber { get; set; }



        //navigation 

        public ICollection<Rental> Rentals{ get; set; }
        public ICollection<PicknDrop> Pickdrops { get; set; }


    }
}
