using RideAggregator.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideAggregator.core.Interfaces
{
    public interface IUserRepository
    {
        public interface IUserRepository : IRepository<User> { }

    }

}
