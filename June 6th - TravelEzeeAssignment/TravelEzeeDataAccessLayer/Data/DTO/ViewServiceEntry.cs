using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEzeeDataAccessLayer.Data.DTO
{
    public class ServiceEntry
    {
        public long ServiceId { get; set; }
        public required string ServiceTypeText { get; set; }
        public required string Source { get; set; }
        public required string Destination { get; set; }
        public double Distance { get; set; }

    }
}