using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId {get;set;}
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password {get;set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        public bool IsAdmin { get; set; }=false;

        //Navigation
        public ICollection<Order> Orders { get; set; }
        public ICollection<StockReplenishment> StockReplenishments { get; set; }

        public ICollection<Cart> Carts { get; set; }
        [InverseProperty("User")]
        public ICollection<Discount> Discounts { get; set; }
    }
}
