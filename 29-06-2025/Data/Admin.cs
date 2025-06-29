using System.ComponentModel.DataAnnotations;

namespace Book.Data
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [StringLength(100)] // Added a length constraint for consistency
        public string AdminName { get; set; }

        [Required]
        [StringLength(100)] // Added a length constraint for consistency
        public string Password { get; set; }

    }
}
