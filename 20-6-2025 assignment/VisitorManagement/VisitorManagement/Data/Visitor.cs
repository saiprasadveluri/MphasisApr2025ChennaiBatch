using System.ComponentModel.DataAnnotations;

namespace VisitorManagement.Data
{
    public class Visitor
    {
        [Required]
        public Guid VisitorId { get; set; }
        [Required]
        [StringLength(50)]  
        public string VisitorName { get; set; }
        [Required]
        public string Location {  get; set; }
        [Required,StringLength(50)]
        public string HostName {  get; set; }
        [Required]
        [DataType("Date")]
         public  DateTime VisitDate {  get; set; }

    }
}
