using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RideAppAgg
{
    public class Customer
    {
        [Key]
        public int CId { get; set; }


        public int UId { get; set; } // Foreign key to the User table
        //[ForeignKey(nameof(UId))]
        //public User? User { get; set; }

        public string? CName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }

}

//        [NotMapped]
//        public PickupDrop? pickC { get; set; } // Navigation property to PickupDrop
//    }
//}
