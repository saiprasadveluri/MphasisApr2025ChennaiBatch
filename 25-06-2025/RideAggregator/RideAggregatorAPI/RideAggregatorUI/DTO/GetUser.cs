namespace RideAggregatorUI.DTO
{
    public class GetUser
    {
        public List<UserDTO> data { get; set; } = new List<UserDTO>();
    }
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
    public class LoginUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

