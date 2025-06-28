using Book.Data;
using Book.DTO;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ISeatRepository
    {
        Task<IEnumerable<Seat>> GetByTheatreIdAsync(int theatreId);
        Task UpdateSeatStatusAsync(int seatId, string status);

        Task<Seat> CreateAsync(Seat seat);
        //Task<SeatDTO> CreateAsync(SeatDTO dto);

        Task DeleteAsync(int seatId);


    }
}
