namespace BookMyShowAPI.DTO
{
    public class BookingRequestDto
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }
        public DateTime ShowTime { get; set; }
    }
}
