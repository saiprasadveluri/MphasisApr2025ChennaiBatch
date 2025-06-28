using System.ComponentModel.DataAnnotations;

namespace Book.DTO
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
