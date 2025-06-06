DataAccess dataAccess = new DataAccess();
List<Location> loclist = dataAccess.GetAllLocations();
dataAccess.AddLocation(5, "Banglore");
foreach (var loc in loclist)
{
    Console.WriteLine($"LocationId:{loc.LocationId} ---LocationName:{loc.LocationName}");
}

List<ServiceType> serTList = dataAccess.GetAllServiceTypes();
dataAccess.AddServiceType(3, "ordinary", 2.3f);
foreach (var ser in serTList)
{
    Console.WriteLine($"ServiceTypeId:{ser.ServiceTypeId}----ServiveTypename:{ser.ServiceTypeText}---Price:{ser.PricePerKm}");
}


List<Service> serList = dataAccess.GetAllServices();
dataAccess.AddService(2, 1, 2, 12);
foreach (var r in serList)
{
    Console.WriteLine($"ServiceId:{r.ServiceId}---ServiceTypeId:{r.ServiceTypeId}----SourceLoc:{r.SourceLocationId}---DestLoc:{r.DestinationLocationId}---Distance:{r.DistanceKm}");
}