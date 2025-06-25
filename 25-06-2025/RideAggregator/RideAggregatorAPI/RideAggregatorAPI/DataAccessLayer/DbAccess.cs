using RideAggregatorAPI.Data;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.DataAccessLayer
{
    public class DbAccess
    {
        RideDbContext context;
        public DbAccess(RideDbContext ctx)
        {
            context = ctx;
        }
        //-----Locations-------
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Locations
                                     select new LocationDTO
                                     {
                                         LocId = obj.LocId,
                                         LocName = obj.LocName
                                     }).ToList();
            return Res;
        }

        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Locations.Where(loc => loc.LocId == id).Select(
                obj => new LocationDTO() { LocId = id, LocName = obj.LocName }).FirstOrDefault();
            return Res;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LocId = Guid.NewGuid();
            location.LocName = loc.LocName;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }
        //------Users-----------
        public bool AddUser(UserDTO data)
        {
            User userdata = new User();
            userdata.UserId = Guid.NewGuid();
            userdata.Name = data.Name;
            userdata.Email = data.Email;
            userdata.Password = data.Password;
            userdata.UserRole = data.UserRole;
            context.User.Add(userdata);
            context.SaveChanges();
            return true;
        }
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> Res = (from obj in context.User
                                     select new UserDTO
                                     {
                                         UserId = obj.UserId,
                                         Name = obj.Name,
                                         Email = obj.Email,
                                         Password = obj.Password,
                                         UserRole = obj.UserRole,
                                     }).ToList();
            return Res;
        }
        //------ Drivers------
        public bool AddDriver(DriverDTO data)
        {
            Driver driverdata = new Driver();
            driverdata.DriverId = Guid.NewGuid();
            driverdata.UserId = data.UserId;
            driverdata.DriverName = data.DriverName;
            driverdata.DriverRating = data.DriverRating;
           
            context.Drivers.Add(driverdata);
            context.SaveChanges();
            return true;
        }
       public  List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> Res = (from obj in context.Drivers
                                 select new DriverDTO
                                 {
                                     DriverId = obj.DriverId,
                                     UserId = obj.UserId,
                                     DriverName = obj.DriverName,
                                     DriverRating = obj.DriverRating
                                    
                                     
                                 }).ToList();
            return Res;

        }
        //------ Customers----
        public bool AddCustomer(CustomerDTO data)
        {
            Customer customerdata = new Customer();
            customerdata.CustomerId = Guid.NewGuid();
            customerdata.UserId = data.UserId;
            customerdata.CustomerName = data.CustomerName;
            customerdata.CustomerPhone = data.CustomerPhone
;

            context.Customers.Add(customerdata);
            context.SaveChanges();
            return true;
        }
        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> Res = (from obj in context.Customers
                                   select new CustomerDTO
                                   {
                                       CustomerId = obj.CustomerId,
                                       UserId = obj.UserId,
                                       CustomerName = obj.CustomerName,
                                       CustomerPhone = obj.CustomerPhone,


                                   }).ToList();
            return Res;

        }
        //-----PickupRide-------
        public bool AddPickupRide(PickupRideDTO data)
        {
           PickupRide pickupridedata = new PickupRide();
            pickupridedata.PickupRideId = Guid.NewGuid();
            pickupridedata.SourceLocation = data.SourceLocation;
            pickupridedata.DestinationLocation = data.DestinationLocation;
            pickupridedata.CustomerId = data.CustomerId;
            pickupridedata.DriverId = data.DriverId;
            

            context.PickupRides.Add(pickupridedata);
            context.SaveChanges();
            return true;
        }
        public List<PickupRideDTO> GetAllPickupRides()
        {
            List<PickupRideDTO> Res = (from obj in context.PickupRides
                                       select new PickupRideDTO
                                       {
                                           PickupRideId = Guid.NewGuid(),
                                           CustomerId = obj.CustomerId,
                                           SourceLocation = obj.SourceLocation,
                                           DestinationLocation = obj.DestinationLocation,
                                           DriverId = obj.DriverId



                                       }).ToList();
            return Res;

        }
        //---RentalRides-----
        public bool AddRentalRide(RentalRideDTO data)
        {
            RentalRide rentalridedata = new RentalRide();
            rentalridedata.RentalId = Guid.NewGuid();
            rentalridedata.Distance = data.Distance;
            rentalridedata.HiredDays = data.HiredDays;
            rentalridedata.CustomerId = data.CustomerId;
            rentalridedata.DriverId = data.DriverId;


            context.Rentalrides.Add(rentalridedata);
            context.SaveChanges();
            return true;
        }
        public List<RentalRideDTO> GetAllRentalRides()
        {
            List<RentalRideDTO> Res = (from obj in context.Rentalrides
                                       select new RentalRideDTO
                                       {
                                           RentalId = Guid.NewGuid(),
                                           Distance = obj.Distance,
                                           HiredDays = obj.HiredDays,
                                           CustomerId = obj.CustomerId,
                                           DriverId = obj.DriverId



                                       }).ToList();
            return Res;
        }
        }
    }
