using System.ComponentModel.DataAnnotations;
namespace RideAppApi
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        public int UserId { get; set; }
        //public User? user { get; set; }
        public string? DriverName { get; set; }
        public string Address {  get; set; } = string.Empty;
        public string Phone {  get; set; } = string.Empty;
        public int Rating { get; set; }
        public int NoOfRides { get; set; }

        //public ICollection<PickUpDrop>? pickDs { get; set; }
    }
}
