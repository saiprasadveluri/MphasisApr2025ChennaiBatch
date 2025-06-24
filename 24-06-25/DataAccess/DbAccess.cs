using RiderApp.DTO;
using RiderApp.Models;
using RiderApp.Data;

namespace RiderApp.DataAccess
{
    public class DbAccess
    {
        AppDbContext context;
        public DbAccess(AppDbContext ctx)
        {
            context = ctx;
        }

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
            var Res = context.Locations.Where(loc => loc.LId == id).Select(
                obj => new LocationDTO() { LId = id, LName = obj.LName }).FirstOrDefault();
            return Res;
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
