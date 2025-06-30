using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchDatabase.EnumsJob;

namespace JobSearchDatabase.Data
{
    public class JobCategory
    {
        [Key]
        public Guid CategoryId { get; set; }
        public JobCategoryName CategoryName { get; set; }

    }
}
