using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;
namespace Book.Services
{
    public class SeatService : BookMyShowDbContext
    {
        public SeatService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
        }
        //*** all Seates
        public async Task<List<SeatDTO>> GetAllSeatsAsync()
        {
            return await this.Seats
                             .Select(s => new SeatDTO
                             {
                                 SeatId = s.SeatId,
                                 SeatNumber = s.SeatNumber,
                                 Row = s.Row,
                                 Type = s.Type,
                                 Status = s.Status,
                                 TheatreId = s.TheatreId
                             })
                             .ToListAsync();
        }

        public async Task<SeatDTO> GetSeatByIdAsync(int id)
        {
            var seat = await this.Seats.FindAsync(id);

            if (seat == null)
            {
                return null;
            }

            return new SeatDTO
            {
                SeatId = seat.SeatId,
                SeatNumber = seat.SeatNumber,
                Row = seat.Row,
                Type = seat.Type,
                Status = seat.Status,
                TheatreId = seat.TheatreId
            };
        }

        public async Task<List<SeatDTO>> GetSeatsByTheatreIdAsync(int theatreId)
        {
            return await this.Seats
                             .Where(s => s.TheatreId == theatreId)
                             .Select(s => new SeatDTO
                             {
                                 SeatId = s.SeatId,
                                 SeatNumber = s.SeatNumber,
                                 Row = s.Row,
                                 Type = s.Type,
                                 Status = s.Status,
                                 TheatreId = s.TheatreId
                             })
                             .ToListAsync();
        }

    
        public async Task<bool> DeleteSeatAsync(int id)
        {
            var seatToDelete = await this.Seats.FindAsync(id);

            if (seatToDelete == null)
            {
                return false;
            }

            this.Seats.Remove(seatToDelete);
            int savedChanges = await this.SaveChangesAsync();

            return savedChanges > 0;
        }
    }
}