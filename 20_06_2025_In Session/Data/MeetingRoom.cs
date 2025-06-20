using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomManagerMVCApp.Data
{
    public class MeetingRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RoomId { get; set; }
        [Required]
        [StringLength(50)]
        public string RoomName {  get; set; }
        [Required]
        public int Capacity {  get; set; }
        [Required]
        [StringLength(50)]
        public string Location {  get; set; }

        //Navigation Prop
        public List<Reservation> ReoomReservations { get; set; }
    }
}
