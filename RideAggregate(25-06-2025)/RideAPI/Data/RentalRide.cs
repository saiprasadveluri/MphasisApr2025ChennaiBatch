using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.Data
{
    public class RentalRide
    {
        [Key]
        public Guid RentalId { get; set; }
        [Required]
        public double Distance { get; set; }
        [Required]
        public int HiredDays {  get; set; }

        [Required]
        [ForeignKey("custData")]
        public Guid CustId { get; set; }

        [Required]
        [ForeignKey("driveData")]
        public Guid DriverId { get; set; }

        //Navigation property
        public Customer custData { get; set; }
        public Driver driveData { get; set; }
    }
}
