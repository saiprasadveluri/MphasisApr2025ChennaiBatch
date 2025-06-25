using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideApi.Data
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid LocId { get; set; }
        [Required]
        [StringLength(50)]
        public string LocationName { get; set; }
    }
}
