using System.ComponentModel.DataAnnotations;

namespace RoomManagerMVCApp.DTO
{
    public class MeetingRoomDTO
    {
        public Guid RoomId { get; set; }        
        public string RoomName { get; set; }       
        public int Capacity { get; set; }        
        public string Location { get; set; }
    }
}
