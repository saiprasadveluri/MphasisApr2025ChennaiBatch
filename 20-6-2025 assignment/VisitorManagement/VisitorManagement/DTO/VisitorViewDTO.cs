namespace VisitorManagement.DTO
{
    public class VistiorViewDTO
    {
        public List<VisitorEntry> visits { get; set; } = new List<VisitorEntry>();
    }
    public class VisitorEntry
    {
        public Guid VisitorId { get; set; }
        public string VisitorName { get; set; }
        public string Location { get; set; }
        public string HostName { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
