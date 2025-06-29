using System.ComponentModel.DataAnnotations;

namespace Book.DTO
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }

    }
    public class AdminCreateDTO
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }

    }


}
