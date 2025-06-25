using RideAggregateAPI.Data;
using RideAggregateAPI.DTO;
using System.Linq;

namespace RideAggregateAPI.DataAccess
{
    public class DBAccess
    {
        RADBContext context;

        public DBAccess(RADBContext ctx)
        {
            context = ctx;
        }
        //--------------Users------------------------
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = (from obj in context.UserInfo
                                  select new UserDTO
                                  {
                                      UserId = obj.UserId,
                                      UserEmail = obj.UserEmail,
                                      UserRole = obj.UserRole
                                  }).ToList();
            return users;
        }
        public bool AddNewUser(UserDTO user)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserId = Guid.NewGuid();
            userInfo.UserEmail = user.UserEmail;
            userInfo.Password = user.Password;
            userInfo.UserRole = user.UserRole;
            context.UserInfo.Add(userInfo);
            context.SaveChanges();
            return true;
        }
        //--------------Customers------------------------
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> users = (from obj in context.CustomerInfo
                                    select new CustomerDTO
                                    {
                                        CustId = obj.CustId,
                                        LoginId = obj.LoginId,
                                        PhoneNumber = obj.PhoneNumber,
                                        CustomerName = obj.CustomerName
                                    }).ToList();
            return users;
        }
        public bool AddCustomer(CustomerDTO c)
        {
            CustomerInfo custi= new CustomerInfo();
            custi.CustId= Guid.NewGuid();
            custi.LoginId= c.LoginId;
            custi.PhoneNumber=c.PhoneNumber;
            custi.CustomerName= c.CustomerName;
     
            context.CustomerInfo.Add(custi);
            context.SaveChanges();
            return true;
        }
        //-------------Drivers-------------------------

        public List<DriversDTO> GetAllDrivers()
        {
            List<DriversDTO> drivers = (from obj in context.DriverInfo
                                  select new DriversDTO
                                  {
                                      DriverId = obj.DriverId,
                                      DriverName = obj.DriverName,
                                      PhoneNumber = obj.PhoneNumber,
                                      VehicleName = obj.VehicleName,
                                      VehicleNo = obj.VehicleNo

                                  }).ToList();
            return drivers;
        }
        public bool AddDriver(DriversDTO d)
        {
            DriverInfo driver= new DriverInfo();
            driver.DriverId = Guid.NewGuid();
            driver.LoginId = d.LoginId;
            driver.DriverName = d.DriverName;
            driver.PhoneNumber = d.PhoneNumber;
            driver.VehicleName = d.VehicleName;
            driver.VehicleNo = d.VehicleNo;
            context.DriverInfo.Add(driver);
            context.SaveChanges();
            return true;
        }

        //----------Location----------------------------

        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Location
                                     select new LocationDTO
                                     {
                                         Id = obj.LocId,
                                         Name = obj.LocName
                                     }).ToList();
            return Res;
        }

        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Location.Where(loc => loc.LocId == id).Select(
                obj => new LocationDTO() { Id = id,Name = obj.LocName }).FirstOrDefault();
            return Res;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LocId = Guid.NewGuid();
            location.LocName = loc.Name;
            context.Location.Add(location);
            context.SaveChanges();
            return true;
        }
        //----------PickUpDropRide----------------------------

        public List<PickUpDropRideDTO> GetAllRides()
        {
            List<PickUpDropRideDTO> Res = (from obj in context.PickUpDropRides
                                           select new PickUpDropRideDTO
                                     {
                                         pickUpId = obj.pickUpId,
                                         custId = obj.custId,
                                         driverId = obj.driverId,
                                         sourceId = obj.sourceId,
                                         destinationId= obj.destinationId,
                                         distance = obj.distance,
                                           }).ToList();
            return Res;
        }

        public List<PickUpDropRideDTO> GetRideById(long id)
        {
            var Res = context.PickUpDropRides
            .Where(r => r.pickUpId == id)
            .Select(r => new PickUpDropRideDTO
            {
                pickUpId = r.pickUpId,
                custId = r.custId,
                driverId = r.driverId,
                sourceId = r.sourceId,
                destinationId = r.destinationId,
                distance = r.distance
            }).ToList();
            return Res;
        }

        public bool AddNewRide(PickUpDropRideDTO pudr)
        {
            PickUpDropRide location = new PickUpDropRide();
            location.pickUpId = pudr.pickUpId;
            location.custId = pudr.custId;
            location.driverId = pudr.driverId;
            location.sourceId = pudr.sourceId;
            location.destinationId = pudr.destinationId;
            location.distance = pudr.distance;

            context.PickUpDropRides.Add(location);
            context.SaveChanges();
            return true;
        }
    }
}
