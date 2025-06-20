using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitorManagement
{
    public class Host
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HostId { get; set; }
        public string? HostName { get; set; }
        public int EmpNumber { get; set; }
        public string? Department { get; set; }
        public int LocationId { get; set; }
        public string? Phone { get; set; }
        [ForeignKey("LocationId")]
        public Location? Locations { get; set; }
    }
}
