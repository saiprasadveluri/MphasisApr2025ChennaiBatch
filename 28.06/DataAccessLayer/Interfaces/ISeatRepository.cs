using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ISeatRepository
    {
        Task<IEnumerable<Seat>> GetByTheatreIdAsync(int theatreId);
        Task UpdateSeatStatusAsync(int seatId, string status);
    }
}
