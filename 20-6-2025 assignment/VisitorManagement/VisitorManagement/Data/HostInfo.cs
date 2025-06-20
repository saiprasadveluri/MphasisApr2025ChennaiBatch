using System.ComponentModel.DataAnnotations;

namespace VisitorManagement.Data
{
    public class HostInfo
    {
        [Required]
        [Key]
        public Guid HostId { get; set; }
        [Required]
        [StringLength(50)]
        public string HostName { get; set; }
        [Required]
        public string Location { get; set; }
        
       
    }
}
