using RideAggrigationAPI.Data;
using RideAggrigationAPI.DTO;

namespace RideAggrigationAPI.DataAccess
{
    public class DbAccess
    {
        RideAggrigateDbContext context;
        public DbAccess(RideAggrigateDbContext ctx)
        {
            context = ctx;
        }

        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Locations
                                     select new LocationDTO
                                     {
                                         LocationId = obj.LocationId,
                                         LocationName = obj.LocationName
                                     }).ToList();
            return Res;
        }

        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Locations.Where(loc => loc.LocationId == id).Select(
                obj => new LocationDTO() { LocationId = id, LocationName = obj.LocationName }).FirstOrDefault();
            return Res;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LocationId = Guid.NewGuid();
            location.LocationName = loc.LocationName;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }


        ////**********
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> customers = (from c in context.Customers
                                           select new CustomerDTO
                                           {
                                               CustomerId = c.CustomerId,
                                               CustomerName = c.CustomerName,
                                               CustomerPhone = c.CustomerPhone,
                                               UserId = c.UserId
                                           }).ToList();
            return customers;
        }
        public CustomerDTO GetCustomerById(Guid id)
        {
            var customer = context.Customers
                .Where(c => c.CustomerId == id)
                .Select(c => new CustomerDTO
                {
                    CustomerId = c.CustomerId,
                    CustomerName = c.CustomerName,
                    CustomerPhone = c.CustomerPhone,
                    UserId = c.UserId
                })
                .FirstOrDefault();

            return customer;
        }

        public bool AddCustomer(CustomerAddDTO dto)
        {
            Customer customer = new Customer
            {
                CustomerId = Guid.NewGuid(),
                CustomerName = dto.CustomerName,
                CustomerPhone = dto.CustomerPhone,
                UserId = dto.UserId
            };

            context.Customers.Add(customer);
            context.SaveChanges();
            return true;
        }
        ////*************

        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> drivers = (from d in context.Drivers
                                       select new DriverDTO
                                       {
                                           DiverId = d.DiverId,
                                           DriverName = d.DriverName,
                                           DriverRating = d.DriverRating,
                                           UserId = d.UserId
                                       }).ToList();
            return drivers;
        }

        public DriverDTO GetDriverById(Guid id)
        {
            var driver = context.Drivers
                .Where(d => d.DiverId == id)
                .Select(d => new DriverDTO
                {
                    DiverId = d.DiverId,
                    DriverName = d.DriverName,
                    DriverRating = d.DriverRating,
                    UserId = d.UserId
                })
                .FirstOrDefault();

            return driver;
        }


        public bool AddDriver(DriverAddDTO dto)
        {
            Driver driver = new Driver
            {
                DiverId = Guid.NewGuid(),
                DriverName = dto.DriverName,
                DriverRating = dto.DriverRating,
                UserId = dto.UserId
            };

            context.Drivers.Add(driver);
            context.SaveChanges();
            return true;
        }
        //***********
        public List<PicupDropDTO> GetAllPickupDrops()
        {
            var res = (from p in context.PicupDrop
                       select new PicupDropDTO
                       {
                           PickupDropId = p.PicupDropId,
                           numofdays = p.numofdays,
                           CustomerId = p.CustomerId,
                           DriverId = p.DriverId,
                           SourceLocationid = p.SourceLocationid,
                           DistinationLocationid = p.DistinationLocationid
                       }).ToList();

            return res;
        }
        //****
        public List<RentalDTO> GetAllRentals()
        {
            List<RentalDTO> rentals = (from r in context.Rentals
                                       select new RentalDTO
                                       {
                                           RentalId = r.RentalId,
                                           CustomerId = r.CustomerId,
                                           DriverId = r.DriverId,
                                           SourceLocationid = r.SourceLocationid,
                                           DistinationLocationid = r.DistinationLocationid
                                       }).ToList();
            return rentals;
        }
        //************
        public List<UserDTO> GetAllUsers()
        {
            return context.Users.Select(u => new UserDTO
            {
                UserId = u.UserId,
                Email = u.Email,
                Password = u.Password,
                UserRole = u.UserRole
            }).ToList();
        }

        public UserDTO GetUserById(Guid id)
        {
            return context.Users.Where(u => u.UserId == id).Select(u => new UserDTO
            {
                UserId = u.UserId,
                Email = u.Email,
                Password = u.Password,
                UserRole = u.UserRole
            }).FirstOrDefault();
        }

        public bool AddUser(UserAddDTO dto)
        {
            User u = new User
            {
                UserId = Guid.NewGuid(),
                Email = dto.Email,
                Password = dto.Password,
                UserRole = dto.UserRole
            };

            context.Users.Add(u);
            context.SaveChanges();
            return true;
        }


    }
}
