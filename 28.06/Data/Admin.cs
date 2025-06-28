using System.ComponentModel.DataAnnotations;

namespace Book.Data
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set;}

    }
}
