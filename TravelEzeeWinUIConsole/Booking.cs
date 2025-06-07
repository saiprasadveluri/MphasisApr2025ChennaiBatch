using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TravelEzeeWinUIConsole
{

    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BookId { get; set; }
        [ForeignKey(nameof(TravelService))]
        public long ServiceId { get; set; }
        [Required]
        public DateTime TravelDate { get; set; }

        public int SeatCount { get; set; }
        public string BookBy { get; set; }
        public Service TravelService { get; set; }
    }
}