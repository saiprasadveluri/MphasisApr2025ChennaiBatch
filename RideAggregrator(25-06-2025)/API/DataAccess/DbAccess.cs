using RideAggerator.DTO;
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
            location.LocId = Guid.NewGuid();
            location.LocationName = loc.Name;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }
        public bool AddUser(UserDataDTO data)
        {
            UserData userData = new UserData();
            userData.UserId = Guid.NewGuid();
            userData.Email = data.Email;
            userData.Password = data.Password;
            userData.UserRole = data.UserRole;
            context.UserDatas.Add(userData);
            context.SaveChanges();
            return true;
        }
        public List<UserDataDTO> GetAllUserData()
        {
            List<UserDataDTO> UserList = (from data in context.UserDatas
                                          select new UserDataDTO
                                          {
                                              UserId = data.UserId,
                                              Email = data.Email,
                                              Password = data.Password,
                                              UserRole = data.UserRole
                                          }).ToList();
            return UserList;
        }
        public bool AddCustomer(CustomerDataDTO data)
        {
            CustomerData customerData = new CustomerData();
            customerData.CustId = Guid.NewGuid();
            customerData.LoginId = data.LoginId;
            customerData.PhoneNumber = data.PhoneNumber;
            customerData.CustomerName = data.CustomerName;
            context.CustomerDatas.Add(customerData);
            context.SaveChanges();
            return true;
        }
        public List<CustomerDataDTO> GetAllCustomerData()
        {
            List<CustomerDataDTO> CustomerList = (from data in context.CustomerDatas
                                          select new CustomerDataDTO
                                          {
                                              CustId = data.CustId,
                                              LoginId = data.LoginId,
                                              PhoneNumber = data.PhoneNumber,
                                              CustomerName = data.CustomerName
                                          }).ToList();
            return CustomerList;
        }
        public List<DriverDataDTO> GetAllDriverData()
        {
            List<DriverDataDTO> DriverList = (from data in context.DriverDatas
                                          select new DriverDataDTO
                                          {
                                              DriverId = data.DriverId,
                                              LoginId = data.LoginId,
                                              PhoneNumber = data.PhoneNumber,
                                              DriverName = data.DriverName
                                          }).ToList();
            return DriverList;
        }
        public bool AddDriver(DriverDataDTO data)
        {
            DriverData driverData = new DriverData();
            driverData.DriverId = Guid.NewGuid();
            driverData.LoginId = data.LoginId;
            driverData.PhoneNumber = data.PhoneNumber;
            driverData.DriverName = data.DriverName;
            context.DriverDatas.Add(driverData);
            context.SaveChanges();
            return true;
        }
        public List<PickupRideDTO> GetAllPickupRide()
        {
            List<PickupRideDTO> PickupList = (from data in context.PickupRides
                                              select new PickupRideDTO
                                              {
                                                  PickupId = data.PickupId,
                                                  CustomerId = data.CustomerId,
                                                  DriverId = data.DriverId,
                                                  SourceId = data.SourceId,
                                                  DestinationId = data.DestinationId,
                                                  Distance = data.Distance,
                                              }).ToList();
            return PickupList;
        }
        public bool AddPickup(PickupRideDTO data)
        {
            PickupRide pickupRide = new PickupRide();
            pickupRide.PickupId = Guid.NewGuid();
            pickupRide.CustomerId = data.CustomerId;
            pickupRide.DriverId = data.DriverId;
            pickupRide.SourceId = data.SourceId;
            pickupRide.DestinationId = data.DestinationId;
            pickupRide.Distance = data.Distance;
            context.PickupRides.Add(pickupRide);
            context.SaveChanges();
            return true;
        }
        public List<RentalRideDTO> GetAllRentalRide()
        {
            List<RentalRideDTO> RentalList = (from data in context.RentalRides
                                              select new RentalRideDTO
                                              {
                                                  RetalRideId = data.RetalRideId,
                                                  CustomerId = data.CustomerId,
                                                  DriverId = data.DriverId,
                                                  SourceId = data.SourceId,
                                                  Distance = data.Distance,
                                                  HiredDays = data.HiredDays,
                                              }).ToList();
            return RentalList;
        }
        public bool AddRental(RentalRideDTO data)
        {
            RentalRide rentalRide = new RentalRide();
            rentalRide.RetalRideId = Guid.NewGuid();
            rentalRide.CustomerId = data.CustomerId;
            rentalRide.DriverId = data.DriverId;
            rentalRide.SourceId = data.SourceId;
            rentalRide.Distance = data.Distance;
            rentalRide.HiredDays = data.HiredDays;
            context.RentalRides.Add(rentalRide);
            context.SaveChanges();
            return true;
        }
    }
}