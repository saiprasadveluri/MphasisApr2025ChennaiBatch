using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
