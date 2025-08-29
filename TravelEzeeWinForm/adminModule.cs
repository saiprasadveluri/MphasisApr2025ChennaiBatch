using System;
using System.Collections.Generic;
using System.IO;
using TravelEzeeConsole.Infra;

namespace TravelEzeeConsole
{
    public class AdminPanel
    {
        private const string FilePath = "";
        private DataHandler dataHandler;
        private const string RequiredRole = "ADMIN";

        public AdminPanel()
        {
            dataHandler = DataHandler.Instance;
        }

        public void SaveServiceData()
        {
            using (StreamWriter writer = new StreamWriter(FilePath + "ServiceData.txt"))
            {
                foreach (Service service in dataHandler.Services)
                {
                    writer.WriteLine(service.GetServiceDetails());
                }
            }
        }

        public void LoadServiceData()
        {
            using (StreamReader reader = new StreamReader(FilePath + "ServiceData.txt"))
            {
                while (true)
                {
                    string serviceEntry = reader.ReadLine();
                    if (serviceEntry == null)
                        break;

                    var serviceDetails = serviceEntry.Split(',');
                    if (serviceDetails.Length == 5)
                    {
                        Service service = new Service()
                        {
                            ServiceCode = serviceDetails[0],
                            StartLocation = int.Parse(serviceDetails[1]),
                            EndLocation = int.Parse(serviceDetails[2]),
                            ServiceCategoryId = int.Parse(serviceDetails[3]),
                            DistanceCovered = double.Parse(serviceDetails[4]),
                        };
                        dataHandler.Services.Add(service);
                    }
                }
            }
        }

        public void LoadServiceCategories()
        {
            using (StreamReader reader = new StreamReader(FilePath + "ServiceCategories.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] categoryDetails = line.Split(',');
                    if (categoryDetails.Length == 4)
                    {
                        ServiceCategory serviceCategory = new ServiceCategory()
                        {
                            CategoryId = int.Parse(categoryDetails[0]),
                            CategoryName = categoryDetails[1],
                            MaxSeats = int.Parse(categoryDetails[2]),
                            RatePerKm = double.Parse(categoryDetails[3]),
                        };
                        dataHandler.ServiceCategories.Add(serviceCategory);
                    }
                }
            }
        }

        public void LoadLocations()
        {
            using (StreamReader reader = new StreamReader(FilePath + "Locations.txt"))
            {
                while (true)
                {
                    string locationLine = reader.ReadLine();
                    if (locationLine == null)
                    {
                        break;
                    }

                    string[] locationDetails = locationLine.Split(',');
                    if (locationDetails.Length == 2)
                    {
                        Location location = new Location()
                        {
                            LocationId = int.Parse(locationDetails[0]),
                            LocationName = locationDetails[1],
                        };
                        dataHandler.Locations.Add(location);
                    }
                }
            }
        }

        public bool DoesLocationExist(int locationId)
        {
            int index = dataHandler.Locations.FindIndex(l => l.LocationId == locationId);
            return index != -1;
        }

        public List<Location> GetAllLocations()
        {
            return dataHandler.Locations;
        }

        public List<ServiceCategory> GetAllServiceCategories()
        {
            return dataHandler.ServiceCategories;
        }

        public void AddLocation(Location location)
        {
            dataHandler.Locations.Add(location);
        }

        public List<Service> GetAllServices()
        {
            return dataHandler.Services;
        }

        public void AddService(Service service)
        {
            dataHandler.Services.Add(service);
        }

        public void DeleteService(string serviceCode)
        {
            var selectedService = dataHandler.Services.FirstOrDefault(s => s.ServiceCode == serviceCode);
            if (selectedService != null)
            {
                dataHandler.Services.Remove(selectedService);
            }
        }

        public List<ServiceCategory> GetAllServiceCategoryTypes()
        {
            return dataHandler.ServiceCategories;
        }

        public void AddServiceCategory(ServiceCategory serviceCategory)
        {
            dataHandler.ServiceCategories.Add(serviceCategory);
        }

        public void RemoveServiceCategory(int serviceCategoryId)
        {
            var serviceCount = dataHandler.Services.Count(s => s.ServiceCategoryId == serviceCategoryId);
            if (serviceCount == 0)
            {
                var selectedServiceCategory = dataHandler.ServiceCategories.FirstOrDefault(sc => sc.CategoryId == serviceCategoryId);
                if (selectedServiceCategory != null)
                {
                    dataHandler.ServiceCategories.Remove(selectedServiceCategory);
                }
            }
            else
            {
                throw new EntityInUseException("This service category is in use and cannot be deleted.");
            }
        }
    }
}
