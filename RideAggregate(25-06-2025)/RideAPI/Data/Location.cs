using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.Data
{
    public class Location
    {
        [Key]
        public Guid LocationId { get; set; }
        [Required]
        public string LocationName {  get; set; }
    }
}
