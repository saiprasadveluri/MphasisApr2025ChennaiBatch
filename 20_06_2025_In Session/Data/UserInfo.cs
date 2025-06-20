using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomManagerMVCApp.Data
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string DisplayName {  get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(10)]
        public string UserRole {  get; set; }
        //Navigation Prop
        public List<Reservation> UserRoomReservartions { get; set; }
    }
}
