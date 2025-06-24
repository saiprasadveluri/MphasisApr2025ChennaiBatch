using System.ComponentModel.DataAnnotations;

namespace RideAppApi
{
    public class Customer
    {
        [Key]
        public int Cust_Id { get; set; }
        public int UserId { get; set; }
        //public User? user { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public long Phone { get; set; }
        //public PickUpDrop? pickC { get; set; }
    }
}
