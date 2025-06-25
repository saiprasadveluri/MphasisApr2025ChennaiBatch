using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideAggregatorCore.Models
{
    public class RentalsRide
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
        public DateTime StartDate { get; set; }
        public int HiredDays { get; set; }
        public double Traveldistance { get; set; }
        public double TollFees { get; set; }

        public Customer Customer { get; set; }
        public Driver Driver { get; set; }

    }
}
