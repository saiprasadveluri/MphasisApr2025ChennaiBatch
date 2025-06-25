using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RideAggregateAPI.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace RideAggregateAPI.DTO
{
    public class CustomerInfo
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CustId { get; set; }
        [Required]
        [ForeignKey(nameof(UserInfo))]
        public Guid LoginId { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string CustomerName { get; set; }

        //Navigation
        public UserInfo UserInfo { get; set; }
        public List<PickUpDropRide> PickupDropRides { get; set; }
        public List<RentalRide> RentalRides { get; set; }
    }
}
