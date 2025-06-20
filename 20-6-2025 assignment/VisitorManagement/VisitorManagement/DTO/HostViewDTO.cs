namespace VisitorManagement.DTO
{
    public class HostViewDTO
    {
        public List<HostEntry> hosts { get; set; } = new List<HostEntry>();
    }
    public class HostEntry
    {
        public Guid HostId { get; set; }
        public string HostName { get; set; }
        public string Location { get; set; }
    }
}
