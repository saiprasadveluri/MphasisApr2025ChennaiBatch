using Microsoft.EntityFrameworkCore;
using RideAggregator.Data;
using RideAggregatorAPI.Data;
using RideAggregatorAPI.DTO;
using System;
using System.Linq;
namespace RideAggregatorAPI.DataAccess
{
    public class DbAccess
    {
        RideDbContext context;
        public DbAccess(RideDbContext ctx)
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
            location.LocId = Guid.NewGuid();
            location.LocationName = loc.Name;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }

        public bool UpdateLocation(LocationDTO loc)
        {

            var location = context.Locations.FirstOrDefault(l => l.LocId == loc.Id);
            if (location != null)
            {
                location.LocationName = loc.Name;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateLocationById(LocationDTO loc)
        {

            var existingLocation = context.Locations.FirstOrDefault(l => l.LocId == loc.Id);

            if (existingLocation == null)
                return false;

            existingLocation.LocationName = loc.Name;

            context.SaveChanges();
            return true;
        }

        public bool DeleteLocationById(Guid id)
        {
            var location = context.Locations.FirstOrDefault(l => l.LocId == id);

            if (location == null)
                return false;

            context.Locations.Remove(location);
            context.SaveChanges();
            return true;
        }

        // GET: All customers
        public List<CustomerDTO> GetAllCustomers()
        {
            return context.CustomerDatas.Select(c => new CustomerDTO
            {
                Id = c.CustId,
                LoginId = c.LoginId,
                CustomerName = c.CustomerName,
                PhoneNumber = c.PhoneNumber
            }).ToList();
        }

        // GET: Customer by ID
        public CustomerDTO GetCustomerById(Guid id)
        {
            var c = context.CustomerDatas.FirstOrDefault(c => c.CustId == id);
            if (c == null) return null;

            return new CustomerDTO
            {
                Id = c.CustId,
                LoginId = c.LoginId,
                CustomerName = c.CustomerName,
                PhoneNumber = c.PhoneNumber
            };
        }

        // POST: Add new customer
        public bool AddCustomer(CustomerDTO dto)
        {
            var cust = new Customer
            {
                CustId = Guid.NewGuid(),
                LoginId = dto.LoginId,
                CustomerName = dto.CustomerName,
                PhoneNumber = dto.PhoneNumber
            };

            context.CustomerDatas.Add(cust);
            context.SaveChanges();
            return true;
        }

        // PUT: Update customer
        public bool UpdateCustomer(CustomerDTO dto)
        {
            var cust = context.CustomerDatas.FirstOrDefault(c => c.CustId == dto.Id);
            if (cust == null) return false;

            cust.CustomerName = dto.CustomerName;
            cust.PhoneNumber = dto.PhoneNumber;
            cust.LoginId = dto.LoginId;

            context.SaveChanges();
            return true;
        }

        // DELETE: Delete customer
        public bool DeleteCustomer(Guid id)
        {
            var cust = context.CustomerDatas.FirstOrDefault(c => c.CustId == id);
            if (cust == null) return false;

            context.CustomerDatas.Remove(cust);
            context.SaveChanges();
            return true;
        }

        public List<AppUserDTO> GetAllAppUsers()
        {
            return context.UserDatas.Select(u => new AppUserDTO
            {
                UserId = u.UserId,
                Email = u.Email,
                Password = u.Password,
                UserRole = u.UserRole
            }).ToList();
        }

        public AppUserDTO GetAppUserById(Guid id)
        {
            var user = context.UserDatas.FirstOrDefault(u => u.UserId == id);
            if (user == null) return null;

            return new AppUserDTO
            {
                UserId = user.UserId,
                Email = user.Email,
                Password = user.Password,
                UserRole = user.UserRole
            };
        }

        public bool AddAppUser(AppUserDTO dto)
        {
            var user = new AppUser
            {
                UserId = Guid.NewGuid(),
                Email = dto.Email,
                Password = dto.Password,
                UserRole = dto.UserRole
            };

            context.UserDatas.Add(user);
            context.SaveChanges();
            return true;
        }

        public bool UpdateAppUser(AppUserDTO dto)
        {
            var user = context.UserDatas.FirstOrDefault(u => u.UserId == dto.UserId);
            if (user == null) return false;

            user.Email = dto.Email;
            user.Password = dto.Password;
            user.UserRole = dto.UserRole;

            context.SaveChanges();
            return true;
        }

        public bool DeleteAppUser(Guid id)
        {
            var user = context.UserDatas.FirstOrDefault(u => u.UserId == id);
            if (user == null) return false;

            context.UserDatas.Remove(user);
            context.SaveChanges();
            return true;
        }
        public bool AddDriver(DriverDTO dto)
        {
            var driver = new Driver
            {
                DriverId = Guid.NewGuid(),
                LoginId = dto.LoginId,
                PhoneNumber = dto.PhoneNumber,
                DriverName = dto.DriverName
            };

            context.DriverDatas.Add(driver);
            context.SaveChanges();
            return true;
        }

        // Get All Drivers
        public List<DriverDTO> GetAllDrivers()
        {
            return context.DriverDatas.Select(d => new DriverDTO
            {
                Id = d.DriverId,
                LoginId = d.LoginId,
                PhoneNumber = d.PhoneNumber,
                DriverName = d.DriverName
            }).ToList();
        }

        // Get Driver By ID
        public DriverDTO GetDriverById(Guid id)
        {
            var driver = context.DriverDatas.FirstOrDefault(d => d.DriverId == id);
            if (driver == null) return null;

            return new DriverDTO
            {
                Id = driver.DriverId,
                LoginId = driver.LoginId,
                PhoneNumber = driver.PhoneNumber,
                DriverName = driver.DriverName
            };
        }

        // Update Driver
        public bool UpdateDriver(Guid id, DriverDTO dto)
        {
            var driver = context.DriverDatas.FirstOrDefault(d => d.DriverId == id);
            if (driver == null) return false;

            driver.LoginId = dto.LoginId;
            driver.PhoneNumber = dto.PhoneNumber;
            driver.DriverName = dto.DriverName;

            context.SaveChanges();
            return true;
        }

        // Delete Driver
        public bool DeleteDriver(Guid id)
        {
            var driver = context.DriverDatas.FirstOrDefault(d => d.DriverId == id);
            if (driver == null) return false;

            context.DriverDatas.Remove(driver);
            context.SaveChanges();
            return true;
        }

        // ADD RIDE
        public bool AddPickupDropRide(PickupDropRideDTO dto)
        {
            var ride = new PickupDropRide
            {
                PickupId = Guid.NewGuid(), // Generate new ID
                CustomerId = dto.CustomerId,
                DriverId = dto.DriverId,
                SourceId = dto.SourceId,
                DestinationId = dto.DestinationId,
                Distance = dto.Distance
            };

            context.PickupRides.Add(ride);
            context.SaveChanges();
            return true;
        }

        // GET ALL
        public List<PickupDropRideDTO> GetAllPickupDropRides()
        {
            return context.PickupRides.Select(p => new PickupDropRideDTO
            {
                CustomerId = p.CustomerId,
                DriverId = p.DriverId,
                SourceId = p.SourceId,
                DestinationId = p.DestinationId,
                Distance = p.Distance
            }).ToList();
        }

        // GET BY ID
        public PickupDropRideDTO GetPickupDropRideById(Guid id)
        {
            var ride = context.PickupRides.FirstOrDefault(p => p.PickupId == id);
            if (ride == null) return null;

            return new PickupDropRideDTO
            {
                CustomerId = ride.CustomerId,
                DriverId = ride.DriverId,
                SourceId = ride.SourceId,
                DestinationId = ride.DestinationId,
                Distance = ride.Distance
            };
        }

        // UPDATE
        public bool UpdatePickupDropRide(Guid id, PickupDropRideDTO dto)
        {
            var ride = context.PickupRides.FirstOrDefault(p => p.PickupId == id);
            if (ride == null) return false;

            ride.CustomerId = dto.CustomerId;
            ride.DriverId = dto.DriverId;
            ride.SourceId = dto.SourceId;
            ride.DestinationId = dto.DestinationId;
            ride.Distance = dto.Distance;

            context.SaveChanges();
            return true;
        }

        // DELETE
        public bool DeletePickupDropRide(Guid id)
        {
            var ride = context.PickupRides.FirstOrDefault(p => p.PickupId == id);
            if (ride == null) return false;

            context.PickupRides.Remove(ride);
            context.SaveChanges();
            return true;
        }

        public bool AddRentalRide(RentalRideDTO dto)
        {
            var ride = new RentalRide
            {
                CustomerId = dto.CustomerId,
                DriverId = dto.DriverId,
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                Distance = dto.Distance
            };

            context.RentalRides.Add(ride);
            return context.SaveChanges() > 0;
        }

        // Get all
        public List<RentalRide> GetAllRentalRides()
        {
            return context.RentalRides
                .Include(r => r.Customer)
                .Include(r => r.Driver)
                .ToList();
        }

        // Get by ID
        public RentalRide GetRentalRideById(int id)
        {
            return context.RentalRides
                .Include(r => r.Customer)
                .Include(r => r.Driver)
                .FirstOrDefault(r => r.RentalRideId == id);
        }

        // Update
        public bool UpdateRentalRide(int id, RentalRideDTO dto)
        {
            var ride = context.RentalRides.Find(id);
            if (ride == null) return false;

            ride.CustomerId = dto.CustomerId;
            ride.DriverId = dto.DriverId;
            ride.StartTime = dto.StartTime;
            ride.EndTime = dto.EndTime;
            ride.Distance = dto.Distance;

            context.RentalRides.Update(ride);
            return context.SaveChanges() > 0;
        }

        // Delete
        public bool DeleteRentalRide(int id)
        {
            var ride = context.RentalRides.Find(id);
            if (ride == null) return false;

            context.RentalRides.Remove(ride);
            return context.SaveChanges() > 0;
        }
    }
}
