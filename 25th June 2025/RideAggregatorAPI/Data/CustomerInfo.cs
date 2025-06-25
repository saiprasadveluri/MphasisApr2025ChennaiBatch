using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class CustomerInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CustomerId { get; set; }
        [Required]
        [ForeignKey(nameof(UserInfo))]
        public Guid LoginId { get; set; }
        [Required]
        [StringLength(30)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(10)]
        public string ContactNo { get; set; }
        public UserInfo UserInfo { get; set; }
        public List<PickUpDropRide> Rides { get; set; }
        public List<RentalRides> RentalRides { get; set; }
    }
}
