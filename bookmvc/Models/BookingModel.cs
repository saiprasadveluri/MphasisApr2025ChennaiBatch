namespace BookMVC.Models
{
    public class BookingModel
    {
        public int CityId {  get; set; }
        public int TheatreId {  get; set; }
        public int MovieId {  get; set; }
        public DateTime ShowTime { get; set; }
        public int UserId {  get; set; }
    }
}
