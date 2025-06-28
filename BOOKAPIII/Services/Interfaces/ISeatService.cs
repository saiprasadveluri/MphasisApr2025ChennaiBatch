using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface ISeatService
    {
        Task<IEnumerable<SeatDTO>> GetByTheatreIdAsync(int theatreId);
        Task UpdateSeatStatusAsync(int seatId, string status);
        Task<SeatDTO> CreateAsync(SeatDTO dto);
        Task DeleteAsync(int seatId);


    }
}
