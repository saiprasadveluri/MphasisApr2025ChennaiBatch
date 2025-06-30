using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchAPI.DataDTO.EnumsJob;

namespace JobSearchAPI.DataDTO { 
    public class JobCategoryDTO
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Range((int)JobCategoryName.InformationTechnology,(int)JobCategoryName.Other)]
        public JobCategoryName CategoryName { get; set; }

    }
}
