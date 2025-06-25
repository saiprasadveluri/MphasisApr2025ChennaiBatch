using RideApi.Data;
using RideApi.DTO;

namespace RideApi.DataAccess
{
    public class DbAccess
    {
        public RideDbContext context;
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
        public bool AddUser(UserDataDTO dataDTO)
        {
            UserData userdata = new UserData();
            userdata.UserId = Guid.NewGuid();
            userdata.Email = dataDTO.Email;
            userdata.Password = dataDTO.Password;
            userdata.UserRole = dataDTO.UserRole;
            context.UserDatas.Add(userdata);
            context.SaveChanges();
            return true;
        }
        public List<UserDataDTO> GetAllUserData()
        {
            List<UserDataDTO> usersList =(from data in context.UserDatas
                                          select new UserDataDTO
                                          {
                                              UserId = data.UserId,
                                              Email = data.Email,
                                              Password = data.Password,
                                              UserRole = data.UserRole
                                          }).ToList();
            return usersList;


        }
        public bool AddDriver(DriverDTO dataDTO)
        {
            DriverData driverdata = new DriverData();
            driverdata.DriverId = Guid.NewGuid();
            driverdata.LoginId = dataDTO.LoginId;
            driverdata.PhoneNumber = dataDTO.PhoneNumber;
            driverdata.DriverName = dataDTO.DriverName;
            context.DriverDatas.Add(driverdata);
            context.SaveChanges();
            return true;
        }
        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> DriverList = (from data in context.DriverDatas
                                          select new DriverDTO
                                          {
                                             DriverId = data.DriverId,
                                              LoginId = data.LoginId,
                                              PhoneNumber = data.PhoneNumber,
                                              DriverName=  data.DriverName

                                          }).ToList();
            return DriverList;


        }
        public bool AddCustomer(CustomerDTO dataDTO)
        {
            CustomerData customerdata = new CustomerData();
            customerdata.CustId = Guid.NewGuid();
            customerdata.LoginId = dataDTO.LoginId;
            customerdata.PhoneNumber = dataDTO.PhoneNumber;
            customerdata.CustomerName = dataDTO.CustomerName;
            context.CustomerDatas.Add(customerdata);
            context.SaveChanges();
            return true;
        }
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> CustomerList = (from data in context.CustomerDatas
                                            select new CustomerDTO
                                            {
                                                CustId = data.CustId,
                                                LoginId = data.LoginId,
                                              PhoneNumber = data.PhoneNumber,
                                                CustomerName = data.CustomerName

                                            }).ToList();
            return CustomerList;


        }
        public bool AddRental(RentalRideDTO dataDTO)
        {
            RentalRides rentalrides = new RentalRides();
            rentalrides.RentalId = Guid.NewGuid();
            rentalrides.CustomerId = dataDTO.CustomerId;
            rentalrides.DriverId = dataDTO.DriverId;
            rentalrides.Distance = dataDTO.Distance;
            rentalrides.HiredDays = dataDTO.HiredDays;
            context.RentalRides.Add(rentalrides);
            context.SaveChanges();
            return true;
        }
        public List<RentalRideDTO> GetAllrentalRides()
        {
            List<RentalRideDTO> RentalrideList = (from data in context.RentalRides
                                                select new RentalRideDTO
                                                {
                                                    RentalId= data.RentalId,
                                                    CustomerId= data.CustomerId,
                                                    DriverId = data.DriverId,
                                                    Distance = data.Distance,
                                                    HiredDays = data.HiredDays

                                                }).ToList();
            return RentalrideList;


        }
        public bool AddPickUp(PickUpRidesDTO dataDTO)
        {
            PickupRide pickrides = new PickupRide();
            pickrides.PickupId = Guid.NewGuid();
            pickrides.CustomerId = dataDTO.CustomerId;
            pickrides.DriverId = dataDTO.DriverId;
            pickrides.SourceId = dataDTO.SourceId;
            pickrides.DestinationId = dataDTO.DestinationId;
            pickrides.Distance = dataDTO.Distance;
            pickrides.StartTime = dataDTO.StartTime;
            pickrides.EndTime = dataDTO.EndTime;
            context.PickupRides.Add(pickrides);
            context.SaveChanges();
            return true;
        }
        public List<PickUpRidesDTO> GetAllPickUpRides()
        {
            List<PickUpRidesDTO> PickUpRideList = (from data in context.PickupRides
                                                   select new PickUpRidesDTO
                                                   {
                                                       PickupId = data.PickupId,
                                                       CustomerId = data.CustomerId,
                                                      DriverId = data.DriverId,
                                                      Distance = data.Distance,
                                                       SourceId = data.SourceId,
                                                       DestinationId = data.DestinationId,
                                                       StartTime = data.StartTime,
                                                       EndTime = data.EndTime,

                                                   }).ToList();
            return PickUpRideList;


        }


    }
}
