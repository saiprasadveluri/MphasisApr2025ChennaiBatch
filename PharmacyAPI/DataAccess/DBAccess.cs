using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;
using System.IO;

namespace OnlinePharmacyAppAPI.DataAccess
{
    public class DBAccess
    {
        OPADBContext context;

        public DBAccess(OPADBContext DBA)
        {
            context = DBA;
        }
        //--------------Users------------------------
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = (from obj in context.Users
                                   select new UserDTO
                                   {
                                       UserId = obj.UserId,
                                       UserName = obj.UserName,
                                       Email = obj.Email,
                                       Password = obj.Password,
                                       PhoneNumber = obj.PhoneNumber,
                                       Address = obj.Address,
                                       IsAdmin = obj.IsAdmin

                                   }).ToList();
            return users;
        }
        public bool AddNewUser(UserDTO user)
        {
            User userInfo = new User();
            userInfo.Email = user.Email;
            userInfo.Password = user.Password;
            userInfo.PhoneNumber = user.PhoneNumber;
            userInfo.Address = user.Address;
            userInfo.IsAdmin = user.IsAdmin;
            context.Users.Add(userInfo);
            context.SaveChanges();
            return true;
        }
        //--------------Medicine------------------------
        public List<MedicineDTO> GetAllMedicines()
        {
            List<MedicineDTO> medicines = (from obj in context.Medicines
                                       select new MedicineDTO
                                       {
                                           MedicineId = obj.MedicineId,
                                           MedName=obj.MedName,
                                           Composition=obj.Composition,
                                           Description=obj.Description,
                                           Manufacturing=obj.Manufacturing,
                                           ExpDate=obj.ExpDate,
                                           Price=obj.Price,
                                           StockQty=obj.StockQty
                                       }).ToList();
            return medicines;
        }
        public bool AddMedicine(MedicineDTO m)
        {
            Medicine med = new Medicine();
            med.MedName = m.MedName;
            med.Composition = m.Composition;
            med.Description = m.Description;
            med.Manufacturing = m.Manufacturing;
            med.ExpDate = m.ExpDate;
            med.Price = m.Price;
            med.StockQty = m.StockQty;
            context.Medicines.Add(med);
            context.SaveChanges();
            return true;
        }
        ////-------------Drivers-------------------------

        //public List<DriversDTO> GetAllDrivers()
        //{
        //    List<DriversDTO> drivers = (from obj in context.DriverInfo
        //                                select new DriversDTO
        //                                {
        //                                    DriverId = obj.DriverId,
        //                                    DriverName = obj.DriverName,
        //                                    PhoneNumber = obj.PhoneNumber,
        //                                    VehicleName = obj.VehicleName,
        //                                    VehicleNo = obj.VehicleNo

        //                                }).ToList();
        //    return drivers;
        //}
        //public bool AddDriver(DriversDTO d)
        //{
        //    DriverInfo driver = new DriverInfo();
        //    driver.DriverId = Guid.NewGuid();
        //    driver.LoginId = d.LoginId;
        //    driver.DriverName = d.DriverName;
        //    driver.PhoneNumber = d.PhoneNumber;
        //    driver.VehicleName = d.VehicleName;
        //    driver.VehicleNo = d.VehicleNo;
        //    context.DriverInfo.Add(driver);
        //    context.SaveChanges();
        //    return true;
        //}

        ////----------Location----------------------------

        //public List<LocationDTO> GetAllLocations()
        //{
        //    List<LocationDTO> Res = (from obj in context.Location
        //                             select new LocationDTO
        //                             {
        //                                 Id = obj.LocId,
        //                                 Name = obj.LocName
        //                             }).ToList();
        //    return Res;
        //}

        //public LocationDTO GetLocationById(Guid id)
        //{
        //    var Res = context.Location.Where(loc => loc.LocId == id).Select(
        //        obj => new LocationDTO() { Id = id, Name = obj.LocName }).FirstOrDefault();
        //    return Res;
        //}

        //public bool AddLocation(LocationDTO loc)
        //{
        //    Location location = new Location();
        //    location.LocId = Guid.NewGuid();
        //    location.LocName = loc.Name;
        //    context.Location.Add(location);
        //    context.SaveChanges();
        //    return true;
        //}
        ////----------PickUpDropRide----------------------------

        //public List<PickUpDropRideDTO> GetAllRides()
        //{
        //    List<PickUpDropRideDTO> Res = (from obj in context.PickUpDropRides
        //                                   select new PickUpDropRideDTO
        //                                   {
        //                                       pickUpId = obj.pickUpId,
        //                                       custId = obj.custId,
        //                                       driverId = obj.driverId,
        //                                       sourceId = obj.sourceId,
        //                                       destinationId = obj.destinationId,
        //                                       distance = obj.distance,
        //                                   }).ToList();
        //    return Res;
        //}

        //public List<PickUpDropRideDTO> GetRideById(long id)
        //{
        //    var Res = context.PickUpDropRides
        //    .Where(r => r.pickUpId == id)
        //    .Select(r => new PickUpDropRideDTO
        //    {
        //        pickUpId = r.pickUpId,
        //        custId = r.custId,
        //        driverId = r.driverId,
        //        sourceId = r.sourceId,
        //        destinationId = r.destinationId,
        //        distance = r.distance
        //    }).ToList();
        //    return Res;
        //}

        //public bool AddNewRide(PickUpDropRideDTO pudr)
        //{
        //    PickUpDropRide location = new PickUpDropRide();
        //    location.pickUpId = pudr.pickUpId;
        //    location.custId = pudr.custId;
        //    location.driverId = pudr.driverId;
        //    location.sourceId = pudr.sourceId;
        //    location.destinationId = pudr.destinationId;
        //    location.distance = pudr.distance;

        //    context.PickUpDropRides.Add(location);
        //    context.SaveChanges();
        //    return true;
        //}
    }
}
