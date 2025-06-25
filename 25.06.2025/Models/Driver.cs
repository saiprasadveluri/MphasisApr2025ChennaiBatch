using System.ComponentModel.DataAnnotations;

namespace RideAggregatorWEBAPI.Data
{
    public class Driver
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string LicenseNumber { get; set; }

        public List<PickupDropRide> PickupRides { get; set; }
        public List<RentalRide> RentalRides { get; set; }
    }
}
