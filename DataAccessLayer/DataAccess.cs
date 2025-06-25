using RideAggregatorAPI.Data;
using RideAggregatorAPI.Data.DBContext;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI
{
    public class DataAccess
    {
        RideDBContext context;

        public string? Name { get; internal set; }

        public DataAccess(RideDBContext ctx)
        {
            context = ctx;
        }
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> res=(from obj in context.Locations
                                   select new LocationDTO
                                   {
                                       Id= obj.LocId,
                                       Name = obj.LocationName
                                   }).ToList();
            return res;
        }
        public LocationDTO GetLocationByID(Guid id)
        {
            var location = context.Locations
                           .Where(loc => loc.LocId == id)
                           .Select(loc => new LocationDTO
                           {
                                Id = loc.LocId,
                                Name = loc.LocationName
                           }).FirstOrDefault();
            return  location;
        }
        public bool AddLocations(LocationDTO dto)
        {
            try
            {
                Location newlocation = new Location
                {
                    LocId = Guid.NewGuid(),
                    LocationName = dto.Name
                };
                context.Locations.Add(newlocation);
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

    }
}
