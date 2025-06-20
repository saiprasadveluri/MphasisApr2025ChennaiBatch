namespace RoomManagerMVCApp.DTO
{
    public class MeetingRoomViewDTO
    {
        public List<RoomEntry> rooms { get;set;}=new List<RoomEntry>();
    }

    public class RoomEntry
    {
        public Guid RoomId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
    }
}
