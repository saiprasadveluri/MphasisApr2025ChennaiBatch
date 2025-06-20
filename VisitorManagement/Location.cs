using System.ComponentModel.DataAnnotations;

namespace VisitorManagement
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public List<Visitor> Visitors { get; set; } = new();
        public List<Host> Hosts { get; set; } = new();

    }
}
