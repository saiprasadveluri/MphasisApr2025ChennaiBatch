namespace OnlineQuizMVC.DTO
{
    public class GetUserData
    {
        List<AccountUserDTO> data { get; set; } = new List<AccountUserDTO>();
    }
    public class AccountUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string ContactNo { get; set; }
    }
    public class GetAccountUserDTO
    {
        public Guid accountId { get; set; }
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contactNo { get; set; }
    }

    public class GetAccountUserDTORes
    {
        public GetAccountUserDTO res { get; set; }
    }
}
