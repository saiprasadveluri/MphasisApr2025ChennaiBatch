using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace RideAggregatorMVC.MVCDTO
{
    public class UserDataDTO
    {
        public Guid userId { get; set; }
        public string email { get; set; }
       
        public string password { get; set; }
        public string userRole { get; set; }
    }
    public class UserLogin
    {
        public List<UserDataDTO> data { get; set; }
    }
    public class Login

    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
