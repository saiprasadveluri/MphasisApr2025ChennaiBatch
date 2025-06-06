using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEasyDB;

namespace TravelEasyDB
{
    public class ServiceType
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ServiceTypeId { get; set; }
        [Column("ServiceTypeName", TypeName = "nvarchar(100)")]
        public string ServiceTypeName { get; set; } = string.Empty;
        public double PricePerkm { get; set; }

        public List<Service>? ServiceLists { get; set; }
    }
}
