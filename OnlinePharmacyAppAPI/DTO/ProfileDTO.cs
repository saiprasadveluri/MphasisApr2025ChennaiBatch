using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.DTO
{
    public class ProfileDTO
    {
        public int UserId { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
