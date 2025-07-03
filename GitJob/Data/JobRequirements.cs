using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class JobRequirements
    {
        public JobRequirements()
        {
            JobRequirementDetailTables = new HashSet<JobRequirementDetail>();
        }
        [Key]
        public int JobRequirementID { get; set; }
        public string JobRequirementTitle { get; set; }

        public virtual ICollection<JobRequirementDetail> JobRequirementDetailTables { get; set; }
    }
}

