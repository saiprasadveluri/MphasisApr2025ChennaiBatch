using Microsoft.EntityFrameworkCore;
using RideAggregatorApp.Data;
using RideAggregatorApp.Model;
using RideAggregatorApp.DTO;

namespace RideAggregatorApp.DataAccess

{
    public class DbAccess
    {
        AppDbContext context;
        public DbAccess(AppDbContext ctx)
        {
            context = ctx;
        }
        //Location
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Locations
                                     select new LocationDTO
                                     {
                                         LId = obj.LId,
                                         LName = obj.LName
                                     }).ToList();

            return Res;
        }
        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Locations.Where(loc => loc.LId == id).Select(loc => new LocationDTO()
            {
                LId = id,
                LName = loc.LName
            }).FirstOrDefault();
            return Res;
        }
        public bool DeletLocationById(Guid id)
        {
            var location = context.Locations.FirstOrDefault(loc => loc.LId == id);
            if (location == null) {
                return false;

            }
            context.Locations.Remove(location);
            context.SaveChanges();
            return true;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LId = Guid.NewGuid();
            location.LName = loc.LName;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;

        }
        

    }
}
