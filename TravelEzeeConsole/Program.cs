
Console.WriteLine("Hello, World!");
DataAccess dataAccess = new DataAccess();
var List = dataAccess.GetAllLocations();
foreach(var data in List)
{
    Console.WriteLine($"Location Id : {data.LocationId} and Location Name:{data.LocationName}");
}
 var Service = dataAccess.GetAllServiceTypes();
 foreach(var data in Service)
 {
    Console.WriteLine($"STypeId:{data.STypeId}-ServiceTypeName:{data.ServiceTypeName}-PricePerKm:{data.PricePerKm}");
 }
 
 dataAccess.AddService(1,2,3,12);
var service =dataAccess.GetAllServices();
foreach(var data in service )
{
   
Console.WriteLine($"ServiceId:{data.ServiceId}-SerTypeId:{data.SerTypeId}-SourceLocId:{data.SourceLocId}-DestLocId:{data.DestLocId}-Distance:{data.Distance}");
}


dataAccess.AddBooking(1,DateTime.Parse("2025-06-05"),4,"Manu");
var book = dataAccess.GetAllBookings();
foreach(var data in book)
{
    Console.WriteLine($"BookId:{data.BookId}-ServiceId:{data.ServiceId}-TravelDate:{data.TravelDate}-SeatCount:{data.SeatCount}-BookBy:{data.BookBy}");
}