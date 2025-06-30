using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchAPI.DataDTO
{
    public class EmployerDTO
    {
        [Key]
        public Guid EmployerId { get; set; }
        public Guid UserId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? EmployerName { get; set; }
        public string? Designation {  get; set; }


    }
}
