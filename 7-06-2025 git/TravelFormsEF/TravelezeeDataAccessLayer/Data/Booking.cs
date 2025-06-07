using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

public class Booking{
    [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.None)]

     public Guid BookId{get;set;}
     [ForeignKey(nameof(TravelService))]

     public long ServiceId{get;set;}

     [Required]

     public DateTime TravelData{get;set;}
     public int SeatCount{get;set;}
     public string BookBy{get;set;}

     public Service TravelService{get;set;}
}