using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEzeeConsole
{
    public class Location
    {
        public int LocationId {  get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Location Id: {LocationId} - Name: {Name}";
        }
    }
}