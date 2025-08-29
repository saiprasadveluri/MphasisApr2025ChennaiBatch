using Microsoft.EntityFrameworkCore;
using RiderApp.Data;
using RiderApp.DTO;
using RiderApp.Models;


namespace RiderApp.DataAccess
{
    public class DbAccess
    {
        AppDbContext context;
        public DbAccess(AppDbContext ctx)
        {
            context = ctx;
        }
        //Location
        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> Res = (from obj in context.Locations
                                     select new LocationDTO
                                     {
                                         LId = obj.LId,
                                         LName = obj.LName
                                     }).ToList();
            return Res;
        }
        public LocationDTO GetLocationById(Guid id)
        {
            var Res = context.Locations.Where(loc => loc.LId == id).Select(
                obj => new LocationDTO() { LId = id, LName = obj.LName }).FirstOrDefault();
            return Res;
        }

        public bool DeleteLocationById(Guid id)
        {
            var location = context.Locations.FirstOrDefault(l => l.LId == id);
            if (location == null)
            {
                return false;
            }

            context.Locations.Remove(location);
            context.SaveChanges();
            return true;
        }

        public bool AddLocation(LocationDTO loc)
        {
            Location location = new Location();
            location.LId = Guid.NewGuid();
            location.LName = loc.LName;
            context.Locations.Add(location);
            context.SaveChanges();
            return true;
        }

        public bool UpdateLocation(LocationDTO updatedLocation)
        {
            var location = context.Locations.FirstOrDefault(l => l.LId == updatedLocation.LId);
            if (location == null)
            {
                return false;
            }

            location.LName = updatedLocation.LName;
            context.SaveChanges();
            return true;
        }
        //Customer 
        public List<CustomerDTO> GetAllCustomer()
        {
            List<CustomerDTO> Res = (from obj in context.Customers
                                     select new CustomerDTO
                                     {
                                         CustId = obj.CustId,
                                         CustName = obj.CustName,
                                         CustPhone = obj.CustPhone,
                                         Email = obj.Email 
                                     }).ToList();
            return Res;
        }
        public CustomerDTO GetCustomerById(Guid id)
        {
            var Res = context.Customers.Where(cust => cust.CustId == id).Select(
            obj => new CustomerDTO()
            {
                CustId = id,
                CustName = obj.CustName,
                CustPhone = obj.CustPhone,
                Email = obj.Email
            }).FirstOrDefault();
            return Res;
        }

        public bool DeleteCustomerById(Guid id)
        {
            var customer = context.Customers.FirstOrDefault(l => l.CustId == id);
            if (customer == null)
            {
                return false;
            }

            context.Customers.Remove(customer);
            context.SaveChanges();
            return true;
        }

        public bool AddCustomer(CustomerDTO customer)
        {
            Customer customers = new Customer();
            customers.CustId = Guid.NewGuid();
            customers.CustName = customer.CustName;
            customers.CustPhone = customer.CustPhone;
            customers.Email = customer.Email;
            //customers.UserInfoId = customer.UserInfoId;
            context.Customers.Add(customers);
            context.SaveChanges();
            return true;
        }

        public bool UpdateCustomer(CustomerDTO updatedCustomer)
        {
            var customer = context.Customers.FirstOrDefault(l => l.CustId == updatedCustomer.CustId);
            if (customer == null)
            {
                return false;
            }

            customer.CustName = updatedCustomer.CustName;
            customer.CustPhone = updatedCustomer.CustPhone;
            customer.Email = updatedCustomer.Email;
            //customer.CustId = updatedCustomer.UserInfoId;
            context.SaveChanges();
            return true;
        }

        //Driver

        public List<DriverDTO> GetAllDrivers()
        {
            List<DriverDTO> Res = (from obj in context.Drivers
                                   select new DriverDTO
                                   {
                                       DriverId = obj.DriverId,
                                       DriverName = obj.DriverName,
                                       PhoneNumber = obj.PhoneNumber,
                                       Email = obj.Email,
                                       LicenseNumber = obj.LicenseNumber,
                                       //UserInfoId = obj.DriverId
                                   }).ToList();
            return Res;
        }

        public bool GetDriverById(Guid id)
        {
            var driver = context.Drivers.FirstOrDefault(l => l.DriverId == id);
            if (driver == null)
            {
                return false;
            }

            context.Drivers.Remove(driver);
            context.SaveChanges();
            return true;
        }

        public bool AddDriver(DriverDTO driver)
        {
            Driver drivers = new Driver();
            drivers.DriverId = Guid.NewGuid();
            drivers.DriverName = driver.DriverName;
            drivers.PhoneNumber = driver.PhoneNumber;
            drivers.Email = driver.Email;
            drivers.LicenseNumber = driver.LicenseNumber;
            //drivers.UserInfoId = driver.UserInfoId;
            context.Drivers.Add(drivers);
            context.SaveChanges();
            return true;
        }

        public bool UpdateDriver(DriverDTO updated)
        {
            var driver = context.Drivers.FirstOrDefault(d => d.DriverId == updated.DriverId);
            if (driver == null)
            {
                return false;
            }

            driver.DriverName = updated.DriverName;
            driver.PhoneNumber = updated.PhoneNumber;
            driver.Email = updated.Email;
            driver.LicenseNumber = updated.LicenseNumber;
            //driver.DriverId = updated.UserInfoId;
            context.SaveChanges();
            return true;
        }

        public bool DeleteDriverById(Guid id)
        {
            var driver = context.Drivers.FirstOrDefault(d => d.DriverId == id);
            if (driver == null)
            {
                return false;
            }

            context.Drivers.Remove(driver);
            context.SaveChanges();
            return true;
        }

        //UserInfo
        public List<AccountDTO> GetAllAccount()
        {
            List<AccountDTO> Res = (from obj in context.accounts
                                     select new AccountDTO
                                     {
                                         Id = obj.Id,
                                         Username = obj.Username,
                                         PasswordHash = obj.PasswordHash,
                                         Role = obj.Role
                                     }).ToList();
            return Res;
        }

        public bool GetAccountById(Guid id)
        {
            var account = context.accounts.FirstOrDefault(l => l.Id == id);
            if (account == null)
            {
                return false;
            }

            context.accounts.Remove(account);
            context.SaveChanges();
            return true;
        }

        public bool AddAccount(AccountDTO account)
        {
            Account accounts = new Account();
            accounts.Id = Guid.NewGuid();
            accounts.Username = account.Username;
            accounts.PasswordHash = account.PasswordHash;
            accounts.Role = account.Role;
            context.accounts.Add(accounts);
            context.SaveChanges();
            return true;
        }

        public bool UpdateAccount(AccountDTO updated)
        {
            var account = context.accounts.FirstOrDefault(d => d.Id == updated.Id);
            if (account == null)
            {
                return false;
            }

            account.Username = updated.Username;
            account.PasswordHash = updated.PasswordHash;
            account.Role = updated.Role;
            context.SaveChanges();
            return true;
        }

        public bool DeleteAccountById(Guid id)
        {
            var account = context.accounts.FirstOrDefault(d => d.Id == id);
            if (account == null)
            {
                return false;
            }
            context.accounts.Remove(account);
            context.SaveChanges();
            return true;
        }

        //PicknDrop

        public List<PicknDropDTO> GetAllPicknDrop()
        {
            return (from obj in context.PickupAndDrop
                    select new PicknDropDTO
                    {
                        RideId = obj.RideId,
                        RideTime = obj.RideTime,
                        Fare = obj.Fare,
                        CustomerId = obj.CustomerId,
                        DriverId = obj.DriverId,
                        PickupLocationId = obj.PickupLocationId,
                        DropLocationId = obj.DropLocationId,
                    }).ToList();
        }


        public bool GetPicknDrop(Guid id)
        {
            var pickndrop = context.PickupAndDrop.FirstOrDefault(l => l.RideId == id);
            if (pickndrop == null)
            {
                return false;
            }

            context.PickupAndDrop.Remove(pickndrop);
            context.SaveChanges();
            return true;
        }

        public bool AddPicknDrop(PicknDropDTO dto)
        {
            PicknDrop record = new PicknDrop
            {
                RideId = Guid.NewGuid(),
                RideTime = dto.RideTime,
                Fare = dto.Fare,
                CustomerId = dto.CustomerId,
                DriverId = dto.DriverId,
                PickupLocationId = dto.PickupLocationId,
                DropLocationId= dto.DropLocationId,
            };

            context.PickupAndDrop.Add(record);
            context.SaveChanges();
            return true;
        }

        public bool UpdatePicknDrop(PicknDropDTO updated)
        {
            var record = context.PickupAndDrop.FirstOrDefault(p => p.RideId == updated.RideId);
            if (record == null)
            {
                return false;
            }

            record.RideTime = updated.RideTime;
            record.Fare = updated.Fare;
            record.CustomerId = updated.CustomerId;
            record.DriverId = updated.DriverId;
            record.PickupLocationId = updated.PickupLocationId;
            record.DropLocationId = updated.DropLocationId;

            context.SaveChanges();
            return true;
        }

        public bool DeletePicknDropById(Guid id)
        {
            var record = context.PickupAndDrop.FirstOrDefault(p => p.RideId == id);
            if (record == null)
            {
                return false;
            }

            context.PickupAndDrop.Remove(record);
            context.SaveChanges();
            return true;
        }
        public List<RentalDTO> GetAllRentals()
        {
            return (from r in context.rentals
                    select new RentalDTO
                    {
                        RentalId = r.RentalId,
                        StartTime = r.StartTime,
                        EndTime = r.EndTime,
                        TotalFare = r.TotalFare,
                        CustomerId = r.CustomerId,
                        DriverId = r.DriverId
                    }).ToList();
        }


        public Rental GetRentalById(Guid id)
        {
            return context.rentals.FirstOrDefault(r => r.RentalId == id);
        }

        public bool AddRental(RentalDTO input)
        {
            try
            {
                var rental = new Rental
                {
                    RentalId = Guid.NewGuid(),
                    StartTime = input.StartTime,
                    EndTime = input.EndTime,
                    TotalFare = input.TotalFare,
                    CustomerId = input.CustomerId,
                    DriverId = input.DriverId
                };
                context.rentals.Add(rental);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateRental(RentalDTO input)
        {
            var existing = context.rentals.FirstOrDefault(r => r.RentalId == input.RentalId);
            if (existing == null) return false;

            existing.StartTime = input.StartTime;
            existing.EndTime = input.EndTime;
            existing.TotalFare = input.TotalFare;
            existing.CustomerId = input.CustomerId;
            existing.DriverId = input.DriverId;

            context.SaveChanges();
            return true;
        }

        public bool DeleteRentalById(Guid id)
        {
            var rental = context.rentals.FirstOrDefault(r => r.RentalId == id);
            if (rental == null) return false;

            context.rentals.Remove(rental);
            context.SaveChanges();
            return true;
        }
    }
}
