using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyApp.DTO
{
    public class GetProfile
    {
        public List<ProfileDTO> data { get; set; }

    }
    public class Profile
    {
        [Key, ForeignKey(nameof(User))]
        public int userId { get; set; }

        [StringLength(20)]
        public string phoneNumber { get; set; }

        public string address { get; set; }

        // Navigation
        public virtual user User { get; set; }
    }
}
