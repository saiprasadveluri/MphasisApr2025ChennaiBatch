using Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Book.Data
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)] // Added length constraint
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required. Please fill it.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(255)] // Added length constraint
        public string UserEmail { get; set; }

        [Required]
        [StringLength(100)] // Assuming hashed password, so max length increased
        public string Password { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120.")] // Added range validation
        public int Age { get; set; }

        [Required]
        [StringLength(10)] // e.g., "Male", "Female", "Other"
        public string Gender { get; set; }

        [Required]
        [StringLength(15)] // Standard phone number length
        [RegularExpression(@"^[0-9]{10,15}$", ErrorMessage = "Mobile number must be 10 to 15 digits long.")] // More flexible regex
        public string MobileNo { get; set; }

        [Required]
        [StringLength(500)] // Added length constraint
        public string Address { get; set; }

        [NotMapped]
        public string? Captcha { get; set; } // Mark as nullable if it's truly not required for persistence

        // One-to-Many relationship with Booking
        // A User can make many Bookings
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        // One-to-Many relationship with Review
        // A User can write many Reviews
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

        // Removed: Tickets - A User doesn't directly own Tickets, Bookings own Tickets.
        // Tickets are accessed via User -> Booking -> Tickets.
    }
}






