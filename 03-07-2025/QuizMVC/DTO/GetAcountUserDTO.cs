namespace QuizMVC.DTO
{
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
        public List<GetAccountUserDTO> data { get; set; }=new List<GetAccountUserDTO>();
    }
    public class GetAccountUserDTORes2
    {
        public GetAccountUserDTO res { get; set; }
    }
}
