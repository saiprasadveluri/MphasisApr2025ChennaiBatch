namespace QuizAPI.DTO
{
    public class AccountAdminDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string AdminName { get; set; }
        public string ContactNo { get; set; }
    }

    public class GetAccountAdminDTO
    {
        public Guid AccountId { get; set; }
        public Guid AdminId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
    }
}
