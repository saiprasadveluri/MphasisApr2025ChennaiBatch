using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RideAggregator.core.Entities;
using System.Threading.Tasks;

namespace RideAggregator.core.Interfaces
{
    public interface IDriverRepository
    {
        public interface IDriverRepository : IRepository<Driver> { }
    }
}
