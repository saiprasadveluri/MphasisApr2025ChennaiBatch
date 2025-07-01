using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class Profile
    {
        [Key, ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        // Navigation
        public virtual User User { get; set; }
    }
}
