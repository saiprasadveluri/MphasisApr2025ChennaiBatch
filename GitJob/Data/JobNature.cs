using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class JobNature
    {
        public JobNature()
        {
            PostJob = new HashSet<PostJob>();
        }

        public int JobNatureID { get; set; }
        public string JobNatureName { get; set; }

        public virtual ICollection<PostJob> PostJob { get; set; }
    }
}

