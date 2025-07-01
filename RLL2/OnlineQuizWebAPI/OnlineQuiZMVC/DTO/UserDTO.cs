namespace OnlineQuiZMVC.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public Guid AccountId { get; set; }
        public string ContactNo { get; set; }
        public string Edit { get; set; }
    }
}
