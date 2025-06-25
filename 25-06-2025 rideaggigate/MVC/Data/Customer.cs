using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.Data
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public long CustomerPhone {  get; set; }

        [Required]

        [ForeignKey("userId")]

        public Guid UserId { get; set; }

        public User userId { get; set; }

        public List<PicupDrop> PicRides { get; set; }
        public List<Rental> RentalRides { get; set; }



    }
}
