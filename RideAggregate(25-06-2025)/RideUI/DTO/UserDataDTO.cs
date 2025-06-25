namespace RideUI.DTO
{
    public class GetUserData
    {
        
        public List<UserDataDTO> data { get; set; } = new List<UserDataDTO>();
    }
    public class UserDataDTO
    {
        public Guid userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userRole { get; set; }
    }
    public class LoginUser
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
