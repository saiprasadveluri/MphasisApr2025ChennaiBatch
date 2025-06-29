using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(100)] // Added length constraint
        public string CityName { get; set; }

        [Required]
        [StringLength(100)] // Added length constraint
        public string State { get; set; }

        [Required]
        [StringLength(100)] // Added length constraint
        public string Country { get; set; }

        // One-to-Many relationship with Theatre
        // A City can have multiple Theatres
        public virtual ICollection<Theatre> Theatres { get; set; } = new List<Theatre>();




    }
}
