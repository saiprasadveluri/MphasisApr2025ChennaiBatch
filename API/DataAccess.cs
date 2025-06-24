namespace RideAppApi
{
    public class DataAccess
    {
        RideDbContext _context;
        public DataAccess(RideDbContext context)
        {
            _context = context;
        }

        public List<Location> GetAllLocations()
        {
            List<Location> res = _context.locations.Select(l =>
            new Location
            {
                LocationId = l.LocationId,
                LocationName = l.LocationName
            }).ToList();
            return res;
        }
        public Location GetLocation(int id)
        {
            var location = _context.locations.Where(l => l.LocationId == id).FirstOrDefault();
            return location;
        }

        public void AddLocation(Location location)
        {
            _context.locations.Add(location);
            _context.SaveChanges();
        }

        public void UpdateLocation(int id ,Location location)
        {
            var existingloc = _context.locations.Where(l => l.LocationId == id).FirstOrDefault();
            if (existingloc != null)
            {
                existingloc.LocationName = location.LocationName;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Location not found.");
            }
        }

        public void DeleteLocation(int id, Location location)
        {
            var existingloc = _context.locations.Where(l => l.LocationId == id).FirstOrDefault();
            if (existingloc != null)
            {
                _context.locations.Remove(existingloc);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Location not found.");
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = _context.Users.Select(u =>
            new User
            {
                UserId = u.UserId,
                Email = u.Email,
                Password = u.Password,
                Role = u.Role
            }).ToList();
            return users;
        }

        public void AddUsers(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUsers(int Id,User user)
        {
            var existingUser = _context.Users.Where(u => u.UserId == Id).FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Role = user.Role;
                _context.SaveChanges();
            }
        }

        public void DeleteUser(int Id)
        {
            var existingUser = _context.Users.Where(u => u.UserId == Id).FirstOrDefault();
            if (existingUser != null)
            {
                _context.Users.Remove(existingUser);
                _context.SaveChanges();
            }

        }

        public List<Customer> GetAllCustomerList()
        {
            List<Customer> list = _context.Customers.Select(c => new Customer
            {
                Cust_Id = c.Cust_Id,
                UserId = c.UserId,
                Name = c.Name,
                Address = c.Address,
                Phone = c.Phone
            }).ToList();
            return list;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomers(int Id, Customer customer)
        {
            var existingUser = _context.Customers.Where(u => u.Cust_Id == Id).FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.UserId = customer.UserId;
                existingUser.Name = customer.Name;
                existingUser.Address = customer.Address;
                existingUser.Phone = customer.Phone;
                _context.SaveChanges();
            }
        }

        public void DeleteCustomers(int Id)
        {
            var existingUser = _context.Customers.Where(u => u.Cust_Id == Id).FirstOrDefault();
            if (existingUser != null)
            {
                _context.Customers.Remove(existingUser);
                _context.SaveChanges();
            }
        }


        public List<Driver> GetAllDriver()
        {
            List<Driver> list = _context.Drivers.Select(c => new Driver
            {
                DriverId = c.DriverId,
                UserId = c.UserId,
                DriverName = c.DriverName,
                Address = c.Address,
                Phone = c.Phone,
                Rating = c.Rating,
                NoOfRides = c.NoOfRides
            }).ToList();
            return list;
        }
        public void AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        public void UpdateDrivers(int Id, Driver driver)
        {
            var existingUser = _context.Drivers.Where(u => u.DriverId == Id).FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.UserId = driver.UserId;
                existingUser.DriverName = driver.DriverName;
                existingUser.Address = driver.Address;
                existingUser.Phone = driver.Phone;
                existingUser.Rating = driver.Rating;
                existingUser.NoOfRides = driver.NoOfRides;
                _context.SaveChanges();
            }
        }

        public void DeleteDriver(int Id)
        {
            var existingUser = _context.Drivers.Where(u => u.DriverId == Id).FirstOrDefault();
            if (existingUser != null)
            {
                _context.Drivers.Remove(existingUser);
                _context.SaveChanges();
            }
        }

        public List<PickUpDrop> GetPickUpDrops()
        {
            List<PickUpDrop> pick = _context.pickups.Select(p => new PickUpDrop
            {
                PId = p.PId,
                DriverId = p.DriverId,
                CustId = p.CustId,
                PickLocId = p.PickLocId,
                DropLocId = p.DropLocId,
                PickUpTime = p.PickUpTime,
                DropTime = p.DropTime
            }).ToList();
            return pick;
        }
        public void AddPickUpDrops(PickUpDrop pickUp)
        {
            DateTime dateTime = DateTime.Now;
            var newPickUp = new PickUpDrop
            {
                DriverId = pickUp.DriverId,
                CustId = pickUp.CustId,
                PickLocId = pickUp.PickLocId,
                DropLocId = pickUp.DropLocId,
                PickUpTime = dateTime.AddHours(-2),
                DropTime = dateTime
            };

            _context.pickups.Add(newPickUp);
            _context.SaveChanges();
        }

        public void UpdatePickUpDrops(int Id, PickUpDrop pickUp)
        {
            var existingUser = _context.pickups.Where(u => u.PId == Id).FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.DriverId = pickUp.DriverId;
                existingUser.CustId = pickUp.CustId;
                existingUser.PickLocId = pickUp.PickLocId;
                existingUser.DropLocId = pickUp.DropLocId;
                existingUser.PickUpTime = pickUp.PickUpTime;
                existingUser.DropTime = pickUp.DropTime;
                _context.SaveChanges();
            }
        }

        public void DeletePickUpsDrops(int Id)
        {
            var existingUser = _context.pickups.Where(u => u.PId == Id).FirstOrDefault();
            if (existingUser != null)
            {
                _context.pickups.Remove(existingUser);
                _context.SaveChanges();
            }
        }

    }
}
