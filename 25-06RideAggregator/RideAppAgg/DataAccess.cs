using Microsoft.EntityFrameworkCore;
namespace RideAppAgg
{
    public class DataAccess
    {
        RideAppDBContext _context;
        public DataAccess(RideAppDBContext context)
        {
            _context = context;
        }

        public List<Location> GetAllLocations()
        {
            List<Location> res = _context.Locations.Select(I =>
            new Location
            {
                LId = I.LId,
                LName = I.LName
            }).ToList();
            return res;
        }

        public Location GetLocationById(int id)
        {
            var location = _context.Locations.Where(I => I.LId == id).
                FirstOrDefault();
            return location;
        }

        public void AddLocation(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
        }

        public void UpdateLocation(int id, Location location)
        {
            var existingLoc = _context.Locations.Where(I => I.LId == id).FirstOrDefault();
            if (existingLoc != null)
            {
                existingLoc.LName = location.LName;
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }

        }

        public void DeleteLocation(int id)
        {
            var existingLoc = _context.Locations.Where(I => I.LId == id).FirstOrDefault();
            if (existingLoc != null)
            {
                _context.Locations.Remove(existingLoc);
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }


        public List<User> GetAllUsers()
        {
            List<User> res = _context.Users.Select(I =>
            new User
            {
                UId = I.UId,
                Email = I.Email,
                Password = I.Password,
                Role = I.Role
            }).ToList();
            return res;
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.Where(I => I.UId == id).FirstOrDefault();
            return user;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(int id, User user)
        {
            var existingUser = _context.Users.Where(I => I.UId == id).FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Role = user.Role;
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var existingUser = _context.Users.Where(I => I.UId == id).FirstOrDefault();
            if (existingUser != null)
            {
                _context.Users.Remove(existingUser);
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public List<Ride> GetAllRides()
        {
            var rideList = _context.Rides.Select(r => new Ride
            {
                RId = r.RId,
                PId = r.PId,
                Distance = r.Distance,
                CostPerKm = r.CostPerKm,

            }).ToList();

            return rideList;
        }

        public Ride GetRideById(int id)
        {
            var ride = _context.Rides.Where(r => r.RId == id).FirstOrDefault();
            return ride;
        }

        public void AddRide(Ride ride)
        {
            _context.Rides.Add(ride);
            _context.SaveChanges();
        }

        public void UpdateRide(int id, Ride ride)
        {
            var existingRide = _context.Rides.Where(r => r.RId == id).FirstOrDefault();
            if (existingRide != null)
            {
                existingRide.PId = ride.PId;
                existingRide.Distance = ride.Distance;
                existingRide.CostPerKm = ride.CostPerKm;
               
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public void DeleteRide(int id)
        {
            var existingRide = _context.Rides.Where(r => r.RId == id).FirstOrDefault();
            if (existingRide != null)
            {
                _context.Rides.Remove(existingRide);
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public List<Driver> GetAllDrivers()
        {
            List<Driver> res = _context.Drivers.Select(I =>
            new Driver
            {
                DId = I.DId,
                UId = I.UId,
                DName = I.DName,
                Address = I.Address,
                Phone = I.Phone,
                Rating = I.Rating,
                NoOfRides = I.NoOfRides

            }).ToList();
            return res;
        }

        public Driver GetDriverById(int id)
        {
            var driver = _context.Drivers.Where(I => I.DId == id).FirstOrDefault();
            return driver;
        }

        public void AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        public void UpdateDriver(int id, Driver driver)
        {
            var existingDriver = _context.Drivers.Where(I => I.DId == id).FirstOrDefault();
            if (existingDriver != null)
            {

                existingDriver.DName = driver.DName;
                existingDriver.Address = driver.Address;
                existingDriver.Phone = driver.Phone;
                existingDriver.Rating = driver.Rating;
                existingDriver.NoOfRides = driver.NoOfRides;
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public void DeleteDriver(int id)
        {
            var existingDriver = _context.Drivers.Where(I => I.DId == id).FirstOrDefault();
            if (existingDriver != null)
            {
                _context.Drivers.Remove(existingDriver);
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        //PickUpDrop Methods

        public List<PickupDrop> GetAllPickupDrops()
        {
            DateTime now = DateTime.Now;
            DateTime oneHourLater = now.AddHours(1);

            List<PickupDrop> res = _context.PickupDrops.Select(I =>
            new PickupDrop
            {
                PId = I.PId,
                DId = I.DId,
                CId = I.CId,
                PickupLocationId = I.PickupLocationId,
                DropLocationId = I.DropLocationId,
                PickupTime = I.PickupTime == default(DateTime) ? now : I.PickupTime,
                DropTime = I.DropTime == default(DateTime) ? oneHourLater : I.DropTime
            }).ToList();
            return res;
        }

        public PickupDrop GetPickupDropById(int id)
        {
            var pickupDrop = _context.PickupDrops.Where(I => I.PId == id).FirstOrDefault();
            return pickupDrop;
        }

        public void AddPickupDrop(PickupDrop pickupDrop)
        {
            _context.PickupDrops.Add(pickupDrop);
            _context.SaveChanges();
        }

        public void UpdatePickupDrop(int id, PickupDrop pickupDrop)
        {
            var existingPickupDrop = _context.PickupDrops.Where(I => I.PId == id).FirstOrDefault();
            if (existingPickupDrop != null)
            {
                existingPickupDrop.DId = pickupDrop.DId;
                existingPickupDrop.CId = pickupDrop.CId;
                existingPickupDrop.PickupLocationId = pickupDrop.PickupLocationId;
                existingPickupDrop.DropLocationId = pickupDrop.DropLocationId;
                existingPickupDrop.PickupTime = pickupDrop.PickupTime;
                existingPickupDrop.DropTime = pickupDrop.DropTime;
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public void DeletePickupDrop(int id)
        {
            var existingPickupDrop = _context.PickupDrops.Where(I => I.PId == id).FirstOrDefault();
            if (existingPickupDrop != null)
            {
                _context.PickupDrops.Remove(existingPickupDrop);
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        //Customer Methods

        public List<Customer> GetAllCustomers()
        {
            List<Customer> res = _context.Customers.Select(I =>
            new Customer
            {
                CId = I.CId,
                UId = I.UId,
                CName = I.CName,
                Address = I.Address,
                Phone = I.Phone
            }).ToList();
            return res;

        }

        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customers.Where(I => I.CId == id).FirstOrDefault();
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            var existingCustomer = _context.Customers.Where(I => I.CId == id).FirstOrDefault();
            if (existingCustomer != null)
            {
                existingCustomer.CName = customer.CName;
                existingCustomer.Address = customer.Address;
                existingCustomer.Phone = customer.Phone;
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            var existingCustomer = _context.Customers.Where(I => I.CId == id).FirstOrDefault();
            if (existingCustomer != null)
            {
                _context.Customers.Remove(existingCustomer);
                _context.SaveChanges();
            }
            else
            {
                _context.SaveChanges();
            }
        }


    }
}

