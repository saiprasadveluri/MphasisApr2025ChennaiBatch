using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggregatetorMVCAPI.DTO
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid LocationId { get; set; }
        [Required]
        [StringLength(50)]
        public string LocationName { get; set; }
    }
}
