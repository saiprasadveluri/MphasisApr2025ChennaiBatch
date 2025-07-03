using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataAccessLayer.Data
{

    public class JobRequirementDetail {
        [Key]

    public int JobRequirementDetailID { get; set; }
    public int JobRequirementID { get; set; }
    public string JobRequirementDetails { get; set; }
    public int PostJobID { get; set; }

    public virtual JobRequirements JobRequirements { get; set; }
    public virtual PostJob PostJob { get; set; }
}
}
