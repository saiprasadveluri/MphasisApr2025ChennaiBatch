using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppMVC.DTO
{
    public class ProfileDTO
    {
        public int userId { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }

    }
    public class GetProfile
    {
        public List<ProfileDTO> data { get; set; }

    }
   
}
