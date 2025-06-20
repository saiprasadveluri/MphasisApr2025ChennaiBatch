using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomManagerMVCApp.Data
{
    public class Reservation
    {
        [Key]
        public int ResId { get; set; }
        [Required]
        [ForeignKey("ReservedByUser")]
        public Guid ReservedById { get; set; }
        [Required]
        [ForeignKey("RoomData")]
        public Guid RoomId { get; set; }
        [Required]
        [StringLength(300)]
        public string Reason {  get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }
        //Navigation Props
        public UserInfo ReservedByUser { get; set; }
        public MeetingRoom RoomData { get; set; }
    }
}
