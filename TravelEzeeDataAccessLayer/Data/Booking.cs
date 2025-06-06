using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid BookId { get; set; }

    [ForeignKey(nameof(TravelService))]
    public long ServiceId { get; set; }

    [Required]
    public DateTime TravelDate { get; set; }
    public int SeatCount { get; set; }
    public string BookBy { get; set; }

    //Navigation
    public Service TravelService { get; set; }
}