using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatorAPI.Data
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }
        public int URole { get; set; }

        

    }
}
