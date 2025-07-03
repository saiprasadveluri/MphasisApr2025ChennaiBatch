using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class JobCategory
    {
        public JobCategory()
        {
            PostJobTables = new HashSet<PostJob>();
        }

        public int JobCategoryID { get; set; }
        public string JobCategorys { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PostJob> PostJobTables { get; set; }
    }
}
