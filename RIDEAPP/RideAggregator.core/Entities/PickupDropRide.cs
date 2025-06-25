using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideAggregator.core.Entities
{
    public class PickupDropRide
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public int SourceLocationId { get; set; }
        public int DestinationLocationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? kmsTravelled{ get; set; }
        public Customer? Customer { get; set; }
        public Driver? Driver { get; set; }
        public Location? SourceLocation { get; set; }
        public Location? DestinationLocation { get; set; }
        
    }
}
