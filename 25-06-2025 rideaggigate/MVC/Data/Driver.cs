using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.Data
{
    public class Driver
    {
        [Key]
        
        [Required]
        public Guid DiverId { get; set; }
        [Required]
        public string DriverName { get; set; }

        [Required]
        public long DriverRating { get; set; }

        [ForeignKey("userId")]
        public Guid UserId { get; set; }
        public User userId { get; set; }

        public List<PicupDrop> PicRides { get; set; }
        public List<Rental> RentalRides { get; set; }
    }
}
