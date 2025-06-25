using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RideAggregator.core.Entities;
using System.Threading.Tasks;

namespace RideAggregator.core.Interfaces
{
    public interface ILocationRepository
    {
        public interface ILocationRepository : IRepository<Location> { }

    }
}
