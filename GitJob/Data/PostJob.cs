using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataAccessLayer.Data
{
    public class PostJob
    {
        public PostJob()
        {
            JobRequirementDetailTables = new HashSet<JobRequirementDetail>();
        }
        [Key]
        public int PostJobID { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public int JobCategoryID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public string Location { get; set; }
        public int Vacancy { get; set; }
        public int JobNatureID { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime ApplicationLastDate { get; set; }
        public DateTime LastDate { get; set; }
        public int JobStatusID { get; set; }
        public string WebUrl { get; set; }

        public virtual Company Company { get; set; }
        public virtual JobCategory JobCategory { get; set; }
        public virtual JobNature JobNature { get; set; }
        public virtual ICollection<JobRequirementDetail> JobRequirementDetailTables { get; set; }
        public virtual JobStatus JobStatus { get; set; }
        public virtual User User { get; set; }
    }
}
