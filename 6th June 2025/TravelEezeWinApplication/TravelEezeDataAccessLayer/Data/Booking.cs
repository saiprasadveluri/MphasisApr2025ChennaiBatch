using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelEezeDataAccessLayer;

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
