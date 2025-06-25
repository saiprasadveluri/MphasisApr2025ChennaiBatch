using RideAggregatetorMVCAPI.DataDTO;
using RideAggregatetorMVCAPI.DTO;
using System.Threading;

namespace RideAggregatetorMVCAPI.DataAccess
{
    
    public class DataAccessLayer
    {
        RideContext context;
        public DataAccessLayer(RideContext con)
        {
            context = con;
        }
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Locations
                                     select new LocationDTO
                                     {
                                         LocId = obj.LocationId,
                                         LocName = obj.LocationName
                                     }).ToList();
            return Res;
        }

        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Locations.Where(loc => loc.LocationId == id).Select(
                obj => new LocationDTO() { LocId = id, LocName = obj.LocationName }).FirstOrDefault();
            return Res;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LocationId = Guid.NewGuid();
            location.LocationName = loc.LocName;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }
        /*public bool RemoveLocation(Guid id)
        {
            Location location = context.Locations.Find(id);

            if (location == null)
            {
                return false;
            }
            context.Locations.Remove(location);
            context.SaveChanges();
            return true;

        }*/
        public bool AddUser(UserDTO user)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserId = Guid.NewGuid();
            userInfo.Email = user.email;
            userInfo.Password= user.password;
            userInfo.UserRole = user.userRole;
            context.UserInfos.Add(userInfo);
            context.SaveChanges();
            return true;
        }
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> Res = (from obj in context.UserInfos
                                     select new UserDTO
                                     {
                                         UserId = obj.UserId,
                                         email = obj.Email,
                                         password= obj.Password,
                                         userRole= obj.UserRole
                                     }).ToList();
            return Res;
        }
        public UserDTO GetUserById(Guid id)
        {
            var Res = context.UserInfos.Where(u=> u.UserId ==u. UserId).Select(
                obj => new UserDTO() { UserId = obj.UserId, email = obj.Email ,password=obj.Password,userRole=obj.UserRole}).FirstOrDefault();
            return Res;
        }
        public bool AddCustomer(CustomerDTO customer)
        {
            Customer cust= new Customer();
            cust.CustomerId = Guid.NewGuid();
            cust.UserId = customer.userId;
            cust.CustomerName = customer.customerName;
            context.Customers.Add(cust);
            context.SaveChanges();
            return true;
        }
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> Res = (from obj in context.Customers
                                 select new CustomerDTO
                                 {
                                     userId = obj.UserId,
                                     customerId = obj.CustomerId,
                                     customerName = obj.CustomerName,
                                 }).ToList();
            return Res;
        }
        public CustomerDTO GetCustById(Guid id)
        {
            var Res = context.Customers.Where(u => u.UserId == u.UserId).Select(
                obj => new CustomerDTO() { userId = obj.UserId,customerId=obj.CustomerId,customerName=obj.CustomerName  }).FirstOrDefault();
            return Res;
        }
        public bool AddDriver(DriverDTO driver)
        {
            Driver d= new Driver();
            d.UserId = driver.userId ;
            d.DriverId = Guid.NewGuid();
            d.DriverName = driver.driverName;
            context.Drivers.Add(d);
            context.SaveChanges();
            return true;
        }
        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> Res = (from obj in context.Drivers
                                     select new DriverDTO
                                     {
                                         userId = obj.UserId,
                                         driverId = obj.DriverId,
                                         driverName = obj.DriverName,
                                     }).ToList();
            return Res;
        }
        public bool AddRentalRide(RentalRideDTO ride)
        {
            RentalRide rRide = new RentalRide();
            rRide.RentalRideId = Guid.NewGuid();
            rRide.CustomerId=ride.customerId;
            rRide.DriverId=ride.driverId;
            rRide.HiredDays= ride.hiredDays;
            rRide.Distance=ride.distance;
            rRide.PricePerKm=ride.pricePerKm;
            context.rentalRides.Add(rRide);
            context.SaveChanges();
            return true;
        }
        public bool AddPickUpRide(PickUpRideDTO pickUpRide)
        {
            PickUpDropRide pRide = new PickUpDropRide();
            pRide.PickUpRideId = Guid.NewGuid();
            pRide.SourceLoc = pickUpRide.sourceLoc;
            pRide.DestinationLoc=pickUpRide.destinationLoc;
            pRide.CustomerId = pickUpRide.customerId;
            pRide.DriverId = pickUpRide.driverId;
            pRide.Price=pickUpRide.price;
            context.pickUpDropRides.Add(pRide);
            context.SaveChanges();
            return true;

        }
    }
}
