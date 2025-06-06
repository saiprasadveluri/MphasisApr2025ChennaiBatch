using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEezeDataAccessLayer.Data.DTO
{
    public class ServiceEntry
    {
        public long ServiceId { get; set; }
        public string ServiceTypeName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
    }
}
