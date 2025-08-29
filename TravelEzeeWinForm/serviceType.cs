using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEzeeConsole
{
    public class ServiceType
    {
        public int ServiceTypeid {  get; set; }
        public string ServiceTypename { get; set; }
        public int MaxSeatCap {  get; set; }
        public double ChargePerKm {  get; set; }

        public override string ToString()
        {
            return $"Id : {ServiceTypeid} - ServiceTypename: {ServiceTypename} Capacity: {MaxSeatCap} ChargePerKm: {ChargePerKm}";
        }
    }
}