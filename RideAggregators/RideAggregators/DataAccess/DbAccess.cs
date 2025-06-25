using RideAggregators.Data;
using RideAggregators.DTO;

namespace RideAggregators.DataAccess
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
        public bool AddUser(UserDataDTO dataDTO)
        {
            UserData userData = new UserData();
            userData.UserId = Guid.NewGuid();
            userData.Email = dataDTO.Email;
            userData.Password = dataDTO.Password;
            userData.UserRole = dataDTO.UserRole;
            context.UserDatas.Add(userData);
            context.SaveChanges();
            return true;
        }
        public List<UserDataDTO> GetAllUserData()
        {
            List<UserDataDTO> usersList = (from data in context.UserDatas
                                           select new UserDataDTO()
                                           {
                                               UserId = data.UserId,
                                               Email = data.Email,
                                               Password = data.Password,
                                               UserRole = data.UserRole
                                           }).ToList();
            return usersList;
        }
        public bool AddDrivers(DriverDTO dataDTO)
        {
            DriverData DriverData = new DriverData();
            DriverData.DriverId = Guid.NewGuid();
            DriverData.LoginId = dataDTO.LoginId;
            DriverData.PhoneNumber = dataDTO.PhoneNumber;
            DriverData.DriverName = dataDTO.DriverName;
            context.DriverDatas.Add(DriverData);
            context.SaveChanges();
            return true;
        }
        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> DriverList = (from data in context.DriverDatas
                                          select new DriverDTO()
                                          {
                                              DriverId = data.DriverId,
                                              LoginId = data.LoginId,
                                              PhoneNumber = data.PhoneNumber,
                                              DriverName = data.DriverName
                                          }).ToList();
            return DriverList;
        }
        public bool AddCustomer(CustomerDTO dataDTO)
        {
            CustomerData CustomerData = new CustomerData();
            CustomerData.CustId = Guid.NewGuid();
            CustomerData.LoginId = dataDTO.LoginId;
            CustomerData.PhoneNumber = dataDTO.PhoneNumber;
            CustomerData.CustomerName = dataDTO.CustomerName;
            context.CustomerDatas.Add(CustomerData);
            context.SaveChanges();
            return true;
        }
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> CustomerList = (from data in context.CustomerDatas
                                              select new CustomerDTO()
                                              {
                                                  CustId = data.CustId,
                                                  LoginId = data.LoginId,
                                                  PhoneNumber = data.PhoneNumber,
                                                  CustomerName = data.CustomerName
                                              }).ToList();
            return CustomerList;
        }
        public bool AddRentalRide(RentalRidesDTO dataDTO)
        {
            RentalRides rentalRides = new RentalRides();
            rentalRides.RetalRideId = Guid.NewGuid();
            rentalRides.CustomerId = dataDTO.CustomerId;
            rentalRides.DriverId = dataDTO.DriverId;
            rentalRides.SourceId= dataDTO.SourceId;
            rentalRides.Distance= dataDTO.Distance;
            rentalRides.HiredDays = dataDTO.HiredDays;
            context.RentalRides.Add(rentalRides);
            context.SaveChanges();
            return true;
        }
        public List<RentalRidesDTO> GetAllRentalRides()
        {
            List<RentalRidesDTO> RentalRidesList = (from data in context.RentalRides
                                              select new RentalRidesDTO()
                                              {
                                                  RetalRideId = data.RetalRideId,
                                                  CustomerId = data.CustomerId,
                                                  DriverId = data.DriverId,
                                                  SourceId = data.SourceId,
                                                  Distance= data.Distance,
                                                  HiredDays = data.HiredDays
                                              }).ToList();
            return RentalRidesList;
        }
        public bool AddPickupRide(PickupRideDTO dataDTO)
        {
            PickupRide pickupRide = new PickupRide();

            pickupRide.PickupId = Guid.NewGuid();
            pickupRide.DriverId = dataDTO.DriverId;
            pickupRide.SourceId = dataDTO.SourceId;
            pickupRide.CustomerId=dataDTO.CustomerId;
            pickupRide.Distance = dataDTO.Distance;
            pickupRide.DestinationId = dataDTO.DestinationId;
    
            context.PickupRides.Add(pickupRide);
            context.SaveChanges();
            return true;
        }
        public List<PickupRideDTO> GetAllPickupRide()
        {
            List<PickupRideDTO> PickupRideList = (from data in context.PickupRides
                                                    select new PickupRideDTO()
                                                    {
                                                        PickupId = data.PickupId,   
                                                        DriverId = data.DriverId,
                                                        SourceId = data.SourceId,
                                                        Distance = data.Distance,
                                                        DestinationId = data.DestinationId
                                                    }).ToList();
            return PickupRideList;
        }
    }
}

