using System.ComponentModel.DataAnnotations;

namespace Book.Data
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string Password { get; set;}

    }
}
