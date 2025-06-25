namespace RideAggregateMVCAPI.DTO
{
    public class UserDTOM
    {
        public Guid userId { get; set; }
        public string userEmail { get; set; }
        public string password { get; set; }
        public string userRole { get; set; }
    }
    public class GetAllUsers()
    {
        public List<UserDTOM> data { get; set; } = new List<UserDTOM>();
    }
    public class LoginUser
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
