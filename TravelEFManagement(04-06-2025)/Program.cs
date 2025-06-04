// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DataAccess dataAccess=new DataAccess();

//View All Data
// List<Location> locationsList=dataAccess.GetAllLocations();
// foreach(var data in locationsList)
// {
//     Console.WriteLine($"Location Id: {data.LocationId} and Location Name: {data.LocationName}");
// }

// List<ServiceType> serviceTypesList=dataAccess.GetAllServiceTypes();
// foreach(var data in serviceTypesList)
// {
//     Console.WriteLine($"Service Type Id: {data.STypeId}, Service Type Name: {data.ServiceTypeName}, Price Per Km: {data.PricePerKm}");
// }

//Add Data

// dataAccess.AddLocation(4,"Bangalore");
// foreach(var data in locationsList)
// {
//     Console.WriteLine($"Location Id: {data.LocationId} and Location Name: {data.LocationName}");
// }

// dataAccess.AddService(1,2,3,12);
// List<Service> serviceList=dataAccess.GetAllServices();
// foreach(var data in serviceList)
// {
//     Console.WriteLine($"ServiceId: {data.ServiceId}, SerTypeId: {data.SerTypeId}, SourceLocId: {data.SourceLocId}, DestLocId: {data.DestLocId}, Distance: {data.Distance}");
// }

// dataAccess.AddBooking(1,DateTime.Parse("2025-06-04"),4,"user1");
// List<Booking> bookingList=dataAccess.GetAllBookings();
// foreach(var data in bookingList)
// {
//     Console.WriteLine($"BookId: {data.BookId}, ServiceId: {data.ServiceId}, TravelDate: {data.TravelDate}, SeatCount: {data.SeatCount}, BookBy: {data.BookBy}");
// }