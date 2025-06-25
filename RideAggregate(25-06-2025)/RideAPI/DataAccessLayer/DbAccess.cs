using RideAPI.Data;
using RideAPI.DTO;
using System.Threading;

namespace RideAPI.DataAccessLayer
{
    public class DbAccess
    {
        public RideDbContext context;
        public DbAccess(RideDbContext ctx)
        {
            context = ctx;
        }
        public bool AddRental(RentalRideDTO data)
        {
            RentalRide rent = new RentalRide();
            rent.RentalId = data.RentalId;
            rent.DriverId = data.DriverId;
            rent.Distance = data.Distance;
            rent.HiredDays = data.HiredDays;
            rent.CustId = data.CustId;
            context.rentalRideList.Add(rent);
            context.SaveChanges();
            return true;
        }
        public List<RentalRideDTO> GetAllRental()
        {
            List<RentalRideDTO> res = (from data in context.rentalRideList
                                       select new RentalRideDTO
                                       {
                                           RentalId = data.RentalId,
                                           DriverId = data.DriverId,
                                           Distance = data.Distance,
                                           HiredDays = data.HiredDays,
                                           CustId = data.CustId
                                       }).ToList();
            return res;
        }

        //PickupRide
        public bool AddPickUp(PickUpRideDTO data)
        {
            PickupRide pickupRide=new PickupRide();
            pickupRide.DriverId = data.DriverId;
            pickupRide.SourceLoc=data.SourceLoc;
            pickupRide.DestinationLoc=data.DestinationLoc;
            pickupRide.PickId = data.PickId;
            pickupRide.CustId = data.CustId;
            context.pickupRideList.Add(pickupRide);
            context.SaveChanges();
            return true;
        }
        public List<PickUpRideDTO> GetAllPickUpRide()
        {
            List<PickUpRideDTO> res = (from data in context.pickupRideList
                                   select new PickUpRideDTO
                                   {
                                       PickId=data.PickId,
                                       SourceLoc=data.SourceLoc,
                                       DestinationLoc=data.DestinationLoc,
                                       CustId=data.CustId,
                                       DriverId =data.DriverId
                                   }).ToList();
            return res;
        }
        //driver
        public bool AddDriver(DriverDTO data)
        {
            Driver driver = new Driver();
            driver.DriverName = data.DriverName;
            driver.DriverRating = data.DriverRating;
            driver.DriverId = Guid.NewGuid();
            driver.UserId = data.UserId;
            context.driverList.Add(driver);
            context.SaveChanges();
            return true;
        }
        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> res = (from data in context.driverList
                                     select new DriverDTO
                                     {
                                         DriverId = data.DriverId,
                                         UserId = data.UserId,
                                         DriverName = data.DriverName,
                                         DriverRating = data.DriverRating,
                                     }).ToList();
            return res;
        }
        //customers
        public bool AddCustomer(CustomerDTO data)
        {
            Customer customer = new Customer();
            customer.CustName = data.CustName;
            customer.CustPhnno = data.CustPhnno;
            customer.CustId=Guid.NewGuid();
            customer.UserId=data.UserId;
            context.customersList.Add(customer);
            context.SaveChanges();
            return true;
        }
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> res=(from data in  context.customersList select new CustomerDTO
            {
                CustId = data.CustId,
                UserId = data.UserId,
                CustName = data.CustName,
                CustPhnno=data.CustPhnno,
            }).ToList();
            return res;
        }
        //users
        public bool AddUser(UserDataDTO dataDTO)
        {
            UserData userData=new UserData();
            userData.UserId = Guid.NewGuid();
            userData.Email = dataDTO.Email;
            userData.Password = dataDTO.Password;  
            userData.UserRole = dataDTO.UserRole;
            context.userDataList.Add(userData);
            context.SaveChanges();
            return true;
        }
        public List<UserDataDTO> GetAllUserData()
        {
            List<UserDataDTO> usersList=(from data in context.userDataList
                                         select new UserDataDTO
                                         {
                                             UserId = data.UserId,
                                             Email = data.Email,
                                             Password = data.Password,
                                             UserRole = data.UserRole
                                         }).ToList();
            return usersList;

        }
        //Locations
        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LocationId = Guid.NewGuid();
            location.LocationName = loc.LocationName;
            context.locationList.Add(location);
            context.SaveChanges();
            return true;
        }
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.locationList
                                     select new LocationDTO
                                     {
                                         LocationId = obj.LocationId,
                                         LocationName = obj.LocationName
                                     }).ToList();
            return Res;
        }

        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.locationList.Where(loc => loc.LocationId == id).Select(
                obj => new LocationDTO() { LocationId = id, LocationName = obj.LocationName }).FirstOrDefault();
            return Res;
        }
    }
}
