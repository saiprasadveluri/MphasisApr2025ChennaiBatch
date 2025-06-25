namespace RideAggregrator.DTO
{
    public class GetUsers
    {
        public List<UserDTO> data {  get; set; }
    }
    public class UserDTO
    {
        public Guid userId { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string userRole { get; set; }
    }
}
