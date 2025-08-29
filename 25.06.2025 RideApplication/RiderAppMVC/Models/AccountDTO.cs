namespace RideAPPMVC.Models
{
    public class GetAllUser
    {
        public List<UserDTO> data {  get; set; } = new List<UserDTO>();
    }
    public class UserDTO
    {
        public int userId { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }

    }
}
