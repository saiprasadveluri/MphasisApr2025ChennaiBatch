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
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required. Please fill it.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string UserEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }

        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile number must be 10 digits long.")]
        public string MobileNo { get; set; }

        public string Address { get; set; }


        [NotMapped]
        public string Captcha { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}






