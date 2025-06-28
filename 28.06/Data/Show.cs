using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Data
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ShowDate { get; set; }
        [Required]
        public TimeOnly ShowTime {  get; set; }
        [Required]
        public int AvailableSeates {  get; set; }
        [Required]
        public long Price {  get; set; }

        [ForeignKey("MovieData")]
        public int MovieId {  get; set; }
        public Movie MovieData {  get; set; }

        [ForeignKey("TheatreData")]
        public int TheatreId {  get; set; }
        public Theatre TheatreData { get; set; }

    }
}
