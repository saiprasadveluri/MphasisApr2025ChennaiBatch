using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideApi.Data
{
    public class RentalRides
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RentalId { get; set; }
        [Required]
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        [Required]
        [ForeignKey(nameof(Driver))]
        public Guid DriverId { get; set; }
       
        [Required]
        public double Distance { get; set; }
        [Required]
        public int HiredDays { get; set; }
        //Navigation
        public CustomerData Customer { get; set; }
        public DriverData Driver { get; set; }
        
    }
}
