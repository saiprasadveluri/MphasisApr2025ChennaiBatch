namespace VisitorManagement.DTO
{
    public class VisitorDTO
    {
        public Guid VisitorId { get; set; }
        public string VisitorName { get; set; }
        public string Location { get; set; }
        public string HostName { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
