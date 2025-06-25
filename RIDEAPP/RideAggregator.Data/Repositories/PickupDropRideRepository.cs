using RideAggregator.core.Entities;
using RideAggregator.core.Interfaces;
using RideAggregator.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideAggregator.Data.Repositories
{
    public class PickupDropRideRepository : Repository<PickupDropRide>, IPickupDropRideRepository
    {
        public PickupDropRideRepository(AppDbContext context) : base(context) { }
    }
}
