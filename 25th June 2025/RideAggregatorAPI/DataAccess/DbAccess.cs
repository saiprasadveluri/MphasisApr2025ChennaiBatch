using RideAggregatorAPI.Data;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.DataAccess
{
    public class DbAccess
    {
        RADBContext context;
        public DbAccess(RADBContext ctx)
        {
            context = ctx;
        }
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.LocationInfos
                                    select new LocationDTO
                                    {
                                        Id = obj.LocationId,
                                        Name = obj.LocationName
                                    }).ToList();
            return Res;
        }
        public List<CustomerDTO> GetAllCustomer()
        {
            List<CustomerDTO> Res = (from obj in context.CustomerInfos
                                     select new CustomerDTO
                                     {
                                         LoginID = obj.LoginId,
                                         CusId = obj.CustomerId,
                                         CusName = obj.CustomerName,
                                         ContactNo = obj.ContactNo
                                     }).ToList();
            return Res;
        }
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> Res = (from obj in context.UserInfos
                                 select new UserDTO
                                 {
                                     UId = obj.UserId,
                                     UEmail = obj.UserEmail,
                                     uPassword = obj.UserPassword,
                                     URole = obj.URole
                                 }).ToList();
            return Res;
        }
        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> Res = (from obj in context.DriverInfos
                                   select new DriverDTO
                                   {
                                       DriverId = obj.DriverId,
                                       LoginId = obj.LoginId,
                                       DriverName = obj.DriverName,
                                       ContactNo = obj.ContactNo
                                   }).ToList();
            return Res;
        }
        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.LocationInfos.Where(loc => loc.LocationId == id).Select(
                obj => new LocationDTO() { Id = id, Name = obj.LocationName }).FirstOrDefault();
            return Res;
        }
        public CustomerDTO GetCustomerById(Guid id)
        {
            var Res = context.CustomerInfos.Where(c => c.CustomerId == id).Select(
                obj => new CustomerDTO() { CusId = id, CusName = obj.CustomerName, LoginID=obj.LoginId, ContactNo=obj.ContactNo }).FirstOrDefault();
            return Res;
        }
        
        public DriverDTO GetDriverById(Guid id)
        {
            var Res = context.DriverInfos.Where(d => d.DriverId == id).Select(
                obj => new DriverDTO() { DriverId = id, DriverName = obj.DriverName, LoginId = obj.LoginId, ContactNo = obj.ContactNo }).FirstOrDefault();
            return Res;
        }
        public bool UpdateLocation(Guid id, LocationDTO location)
        {
            var Res = context.LocationInfos.Where(l => l.LocationId == id).FirstOrDefault();
            if (Res != null)
            {
                Res.LocationName = location.Name;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCustomer(Guid id , CustomerDTO customer)
        {
            var Res = context.CustomerInfos.Where(c => c.CustomerId==id).FirstOrDefault();
            if (Res != null)
            {
                Res.CustomerName = customer.CusName;
                Res.LoginId = customer.LoginID;
                Res.ContactNo = customer.ContactNo;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateUser(Guid id , UserDTO user)
        {
            var Res = context.UserInfos.Where(u => u.UserId==id).FirstOrDefault();
            if (Res != null)
            {
                Res.UserEmail = user.UEmail;
                Res.UserPassword = user.uPassword;
                Res.URole = user.URole;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateDriver(Guid id , DriverDTO driver)
        {
            var Res = context.DriverInfos.Where(d =>  d.DriverId==id).FirstOrDefault();
            if (Res != null)
            {
                Res.DriverName = driver.DriverName;
                Res.LoginId = driver.LoginId;
                Res.ContactNo = driver.ContactNo;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteLocation(Guid id)
        {
            var Res = context.LocationInfos.Where(l => l.LocationId == id).FirstOrDefault();
            if (Res != null)
            {
                context.LocationInfos.Remove(Res);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteCustomer(Guid id)
        {
            var Res = context.CustomerInfos.Where(c => c.CustomerId==id).FirstOrDefault();
            if(Res != null)
            {
                context.CustomerInfos.Remove(Res);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteUser(Guid id)
        {
            var Res = context.UserInfos.Where(u =>  u.UserId==id).FirstOrDefault();
            if (Res != null)
            {
                context.UserInfos.Remove(Res);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false ;
            }
        }
        public bool DeleteDriver(Guid id)
        {
            var Res = context.DriverInfos.Where(d => d.DriverId==id).FirstOrDefault();
            if (Res != null)
            {
                context.DriverInfos.Remove(Res);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddLocation(LocationDTO loc)
        {
            LocationInfo location = new LocationInfo();
            location.LocationId = Guid.NewGuid();
            location.LocationName = loc.Name;
            context.LocationInfos.Add(location);
            context.SaveChanges();
            return true;
        }
        public bool AddUser(UserDTO u)
        {
            UserInfo user = new UserInfo();
            user.UserId = Guid.NewGuid();
            user.UserEmail = u.UEmail;
            user.UserPassword = u.uPassword;
            user.URole = u.URole;
            context.UserInfos.Add(user);
            context.SaveChanges();
            return true;

        }
        public bool AddCustomer(CustomerDTO cust)
        {
            CustomerInfo customer = new CustomerInfo();
            customer.CustomerId = Guid.NewGuid();
            customer.LoginId = cust.LoginID;
            customer.CustomerName = cust.CusName;
            customer.ContactNo = cust.ContactNo;
            context.CustomerInfos.Add(customer);
            context.SaveChanges();
            return true;
        }
        public bool AddDriver(DriverDTO driver)
        {
            DriverInfo drivers = new DriverInfo();
            drivers.DriverId = Guid.NewGuid();
            drivers.LoginId = driver.LoginId;
            drivers.DriverName = driver.DriverName;
            drivers.ContactNo = driver.ContactNo;
            context.DriverInfos.Add(drivers);
            context.SaveChanges();
            return true;
        }
    }
}
