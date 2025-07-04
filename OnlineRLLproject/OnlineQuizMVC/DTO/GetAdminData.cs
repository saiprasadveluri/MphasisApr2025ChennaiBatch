namespace OnlineQuizMVC.DTO
{
    public class GetAdminData
    {
        List<AccountAdminDTO> data { get; set; } = new List<AccountAdminDTO>();
    }
    public class AccountAdminDTO
    {
        public string email { get; set; }
        public string password { get; set; }
        public string adminName { get; set; }
        public string contactNo { get; set; }
    }
    public class GetAccountAdminDTO
    {
        public Guid accountId { get; set; }
        public Guid adminId { get; set; }
        public string adminName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contactNo { get; set; }
    }

    public class GetAccountAdminDTORes
    {
        public GetAccountAdminDTO res { get; set; }
    }
}
