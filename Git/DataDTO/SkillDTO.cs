using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchAPI.DataDTO
{
    public class SkillDTO
    {
        [Key]
        public Guid SkillId { get; set; }    
        public string? SkillName { get; set; }
        public string? SkillCategory { get; set; }
       
    }
}
