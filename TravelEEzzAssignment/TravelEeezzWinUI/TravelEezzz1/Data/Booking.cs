using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
public class Booking
{
    [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.None)]
   public Guid BookId{get;set;}

   [ForeignKey(nameof(Travelservice))]
   public long ServiceId{get;set;}

   [Required]
   public DateTime TravelDate{get;set;}

   public int seatCount{get;set;}

   public string BookBy{get;set;}

   public Service Travelservice{get;set;}


}