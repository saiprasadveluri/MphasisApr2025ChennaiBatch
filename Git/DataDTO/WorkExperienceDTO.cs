using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchAPI.DataDTO
{
    public class WorkExperienceDTO
    {
        [Key]
        public Guid WorkExperienceId {  get; set; }
        [Required]
        public Guid CandidateId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [StringLength(500)]
        public string JobDescription { get; set; }

        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }
        

    }
}
