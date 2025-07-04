using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.Models
{
    public class AdminInfo
    {
        [Key]
        public Guid AdminId { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        [ForeignKey(nameof(userData))]
        public Guid AccountId { get; set; }
        [Required]
        public string ContactNo { get; set; }

        //navigation property
        public Account userData { get; set; }
    }
}
