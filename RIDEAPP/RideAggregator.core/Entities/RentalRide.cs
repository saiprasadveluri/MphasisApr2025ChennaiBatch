using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideAggregator.core.Entities
{
    public class RentalRide
    {
        public int Id { get; set; }
        public int CustomerId{ get; set; }
        public int DriverId{ get; set; }
        public DateTime Startdate { get; set; }
        public int HiredDays { get; set; }
        public double TravelDistance { get; set; }
        public double TollFees{ get; set; }
        public Customer? Customer { get; set; }
        public Driver? Driver { get; set; }


    }
}
