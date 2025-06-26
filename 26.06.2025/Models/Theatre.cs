using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class Theatre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
