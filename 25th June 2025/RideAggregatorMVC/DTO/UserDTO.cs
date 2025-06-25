namespace RideAggregatorMVC.DTO
{
    public class UserDTO
    {
        public Guid uId { get; set; }
        public string uEmail { get; set; }
        public string uPassword { get; set; }
        public int uRole { get; set; }
    }
    public class GetAllUsers()
    {
        public List<UserDTO> data { get; set; } = new List<UserDTO>();
    }
}
