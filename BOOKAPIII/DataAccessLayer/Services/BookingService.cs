using AutoMapper;
using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Book.DTO;
using Book.Services.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repo;
        private readonly IMapper _mapper;
        private readonly ITicketRepository _ticketRepo;
        public BookingService(IBookingRepository repo, IMapper mapper,ITicketRepository ticketRepo)
        {
            _repo = repo;
            _mapper = mapper;
            _ticketRepo = ticketRepo;
        }

        public async Task<BookingDTO> CreateAsync(BookingDTO dto)
        {
            var selectedSeats = await _repo.GetSeatsByIdsAsync(dto.SeatIds);
            var ticket = new Ticket
            {
                UserId = dto.UserId,
                MovieId = dto.MovieId,
                TheaterId = dto.TheaterId,
                ShowId = dto.ShowId,
                TicketDate = dto.BookingDate,
                Seats = selectedSeats
            };

            
            var createdTicket = await _ticketRepo.CreateAsync(ticket);

        
            var booking = _mapper.Map<Booking>(dto);
            booking.TicketId = createdTicket.TicketId;

            var createdBooking = await _repo.CreateAsync(booking);
            return _mapper.Map<BookingDTO>(createdBooking);
            //var entity = _mapper.Map<Booking>(dto);
            //var created = await _repo.CreateAsync(entity);
            //return _mapper.Map<BookingDTO>(created);
        }

        public async Task<IEnumerable<BookingDTO>> GetByUserIdAsync(int userId)
            => _mapper.Map<IEnumerable<BookingDTO>>(await _repo.GetByUserAsync(userId));

        public async Task CancelAsync(int bookingId)
            => await _repo.UpdateStatusAsync(bookingId, "Cancelled");

        public async Task RescheduleAsync(int bookingId, DateTime newDate, TimeOnly newTime)
            => await _repo.RescheduleAsync(bookingId, newDate, newTime);

        public async Task DeleteAsync(int bookingId)
        {
            await _repo.DeleteAsync(bookingId);
        }

    }
}
