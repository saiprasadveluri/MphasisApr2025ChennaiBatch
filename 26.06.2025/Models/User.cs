using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class User
    {
       
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string City { get; set; }

            public ICollection<Booking> Bookings { get; set; }
            public ICollection<Review> Reviews { get; set; }
            public ICollection<Rating> Ratings { get; set; }
            public ICollection<Comment> Comments { get; set; }
        }
    }

