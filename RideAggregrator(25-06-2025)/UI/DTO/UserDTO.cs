namespace RideAggeratorUI.DTO
{
    public class GetUsers
    {
        public List<UserDTO> data {  get; set; }
    }
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
