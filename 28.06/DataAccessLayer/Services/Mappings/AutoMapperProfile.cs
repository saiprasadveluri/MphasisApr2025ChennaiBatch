using AutoMapper;
using Book.Data;
using Book.DTO;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Movie, MovieDTO>().ReverseMap();
        CreateMap<User, UserDTO>().ReverseMap();
        CreateMap<Admin, AdminDTO>().ReverseMap();
        CreateMap<Booking, BookingDTO>().ReverseMap();
        CreateMap<Seat, SeatDTO>().ReverseMap();
        CreateMap<Ticket, TicketDTO>().ReverseMap();
        CreateMap<Review, ReviewDTO>().ReverseMap();
        CreateMap<Show, ShowDTO>().ReverseMap();
        CreateMap<Theatre, TheatreDTO>().ReverseMap();
        CreateMap<City, CityDTO>().ReverseMap();
        CreateMap<Genre, GenreDTO>().ReverseMap();
        CreateMap<Language, LanguageDTO>().ReverseMap();
    }
}