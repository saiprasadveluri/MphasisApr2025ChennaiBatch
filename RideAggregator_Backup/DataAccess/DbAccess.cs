using RideAggregatorAPI.Data;
using RideAggregatorAPI.DTO;
using System.Linq;
namespace RideAggregatorAPI.DataAccess
{
    public class DbAccess
    {
        RideDBContext context;
        public DbAccess(RideDBContext ctx) 
        {
            context = ctx;
        }

        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Locations
                                  select new LocationDTO
                                  {
                                      Id = obj.LocId,
                                      Name = obj.LocationName
                                  }).ToList();
            return Res;
        }

        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Locations.Where(loc => loc.LocId == id).Select(
                obj => new LocationDTO() { Id = id, Name = obj.LocationName }).FirstOrDefault();
            return Res;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LocId=Guid.NewGuid();
            location.LocationName=loc.Name;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }
    }
}
