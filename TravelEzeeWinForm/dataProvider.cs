using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TravelEzeeConsole
{
    internal class DataProvider
    {
        private DataProvider()
        {
            _locations = new List<Location>();
            _servicesTypes= new List<ServiceType>();
            _services = new List<Service>();
        }
        private static DataProvider _instance;
        public static DataProvider Instance 
        { 
            get
            {
                if(_instance == null)
                    _instance = new DataProvider();
                return _instance;
            } 
        }
        private List<Location> _locations;
        private List<ServiceType> _servicesTypes;
        private List<Service> _services;
        private List<Booking> _bookings;
        //Properties.
        public List<Location> Locations {  get { return _locations; } }
        public List<ServiceType> ServicesTypes { get { return _servicesTypes; } }
        public List<Service> Services { get { return _services; } }
        public List<Booking> Bookings { get { return _bookings; } }
    }
}