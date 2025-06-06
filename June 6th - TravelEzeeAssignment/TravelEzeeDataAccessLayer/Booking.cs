
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid BookingId { get; set; }
    
    [ForeignKey(nameof(TravelService))]
    public long ServiceId { get; set; }

    [Required]
    public DateTime TravelDate { get; set; }
    public int NumberOfSeats { get; set; }
    public required string BookedBy { get; set; }
    
    //Navigation
    public required Service TravelService { get; set; }
}