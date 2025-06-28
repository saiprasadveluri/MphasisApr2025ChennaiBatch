using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repo;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<BookingDTO> CreateAsync(BookingDTO dto)
        {
            var entity = _mapper.Map<Booking>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<BookingDTO>(created);
        }

        public async Task<IEnumerable<BookingDTO>> GetByUserIdAsync(int userId)
            => _mapper.Map<IEnumerable<BookingDTO>>(await _repo.GetByUserAsync(userId));

        public async Task CancelAsync(int bookingId)
            => await _repo.UpdateStatusAsync(bookingId, "Cancelled");

        public async Task RescheduleAsync(int bookingId, DateTime newDate, TimeOnly newTime)
            => await _repo.RescheduleAsync(bookingId, newDate, newTime);
    }
}
