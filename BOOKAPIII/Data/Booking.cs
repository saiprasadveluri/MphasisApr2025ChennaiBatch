using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Book.Data;

public class Booking
{
    [Key]
    public int BookingId { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime BookingDate { get; set; }

    [Required]
    public TimeOnly ShowTime { get; set; }

    [Required]
    public int MovieId { get; set; }
    public Movie MovieData { get; set; }

    public int NumberOfTickets { get; set; }

    [Required]
    [StringLength(20)]
    public string Status { get; set; }

    [Required]
    public long TotalAmount { get; set; }

    public int UserId { get; set; }
    public User UserData { get; set; }

    [Required]
    public int ShowId { get; set; }
    public Show ShowData { get; set; }

    public int TheaterId { get; set; }
    public Theatre TheatreData { get; set; }

    //[ForeignKey("TicketData")]
    //public int? TicketId { get; set; }
    public int? TicketId { get; set; }

    [ForeignKey("TicketId")]
    public Ticket TicketData { get; set; }


    //[InverseProperty("Bookings")]
    //public Ticket TicketData { get; set; }
}
