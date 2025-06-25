namespace RideAggregatetorMVCAPI.DataDTO
{
   
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string userRole { get; set; }
    }
}
