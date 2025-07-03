using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataAccessLayer.Data
{
    public class JobStatus
    {
        public JobStatus()
        {
            PostJob = new HashSet<PostJob>();
        }
        [Key]
        public int JobStatusID { get; set; }
        public string JobStatuss { get; set; }
        public string StatusMessage { get; set; }

        public virtual ICollection<PostJob> PostJob { get; set; }
    }
}
