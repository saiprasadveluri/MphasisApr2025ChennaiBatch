using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEzeeConsole
{
    public class BookingModule
    {
        private DataProvider dataProvider;
        public BookingModule() { dataProvider = DataProvider.Instance; }
        public List<Service> GetServicesBetweenLocations(int Start,int Dest)
        {
           return  dataProvider.Services.Where(srv=>srv.FromLocation==Start&&srv.ToLocation==Dest).ToList();
        }

        public void AddBooking(Booking booking)
        {
            dataProvider.Bookings.Add(booking);
        }
    }
}