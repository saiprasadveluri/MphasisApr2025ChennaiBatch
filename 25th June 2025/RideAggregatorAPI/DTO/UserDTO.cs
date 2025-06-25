namespace RideAggregatorAPI.DTO
{
    public class UserDTO
    {
        public Guid UId { get; set; }
        public string UEmail { get; set; }
        public string uPassword { get; set; }
        public int URole { get; set; }
    }
}
