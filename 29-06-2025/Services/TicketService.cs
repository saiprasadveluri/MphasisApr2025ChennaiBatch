using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Services
{
    public class TicketService : BookMyShowDbContext
    {
        public TicketService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
        }

        private string GenerateTicketReference()
        {
            return "TIK" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        public async Task<List<TicketDTO>> GetAllTicketsAsync()
        {
            return await this.Tickets
                             .Select(t => new TicketDTO
                             {
                                 TicketId = t.TicketId,
                                 BookingId = t.BookingId,
                                 SeatId = t.SeatId
                             })
                             .ToListAsync();
        }

        public async Task<TicketDTO> GetTicketByIdAsync(int id)
        {
            var ticket = await this.Tickets.FindAsync(id);

            if (ticket == null)
            {
                return null;
            }

            return new TicketDTO
            {
                TicketId = ticket.TicketId,
                BookingId = ticket.BookingId,
                SeatId = ticket.SeatId
            };
        }

        public async Task<List<TicketDTO>> GetTicketsByBookingIdAsync(int bookingId)
        {
            return await this.Tickets
                             .Where(t => t.BookingId == bookingId)
                             .Select(t => new TicketDTO
                             {
                                 TicketId = t.TicketId,
                                 BookingId = t.BookingId,
                                 SeatId = t.SeatId
                             })
                             .ToListAsync();
        }

        public async Task<TicketDTO> CreateTicketAsync(int bookingId, int seatId)
        {
            if (bookingId <= 0 || seatId <= 0)
            {
                throw new ArgumentException("Invalid BookingId or SeatId.");
            }

            var bookingExists = await this.Bookings.AnyAsync(b => b.BookingId == bookingId);
            if (!bookingExists)
            {
                throw new InvalidOperationException($"Booking with ID {bookingId} not found.");
            }

            var seatExists = await this.Seats.AnyAsync(s => s.SeatId == seatId);
            if (!seatExists)
            {
                throw new InvalidOperationException($"Seat with ID {seatId} not found.");
            }

            var isSeatAlreadyTicketedInBooking = await this.Tickets
                                                           .AnyAsync(t => t.BookingId == bookingId && t.SeatId == seatId);
            if (isSeatAlreadyTicketedInBooking)
            {
                throw new InvalidOperationException($"Seat ID {seatId} is already assigned a ticket within Booking ID {bookingId}.");
            }

            var ticket = new Ticket
            {
                BookingId = bookingId,
                SeatId = seatId,
                
            };

            this.Tickets.Add(ticket);
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new TicketDTO
                {
                    TicketId = ticket.TicketId,
                    BookingId = ticket.BookingId,
                    SeatId = ticket.SeatId
                };
            }
            return null;
        }

        public async Task<TicketDTO> UpdateTicketAsync(int id, TicketDTO ticketUpdate)
        {
            var existingTicket = await this.Tickets.FindAsync(id);

            if (existingTicket == null)
            {
                return null;
            }

            if (ticketUpdate.BookingId <= 0 || ticketUpdate.SeatId <= 0)
            {
                throw new ArgumentException("Invalid BookingId or SeatId for update.");
            }

            if (existingTicket.BookingId != ticketUpdate.BookingId)
            {
                var bookingExists = await this.Bookings.AnyAsync(b => b.BookingId == ticketUpdate.BookingId);
                if (!bookingExists)
                {
                    throw new InvalidOperationException($"Booking with ID {ticketUpdate.BookingId} not found for update.");
                }
            }

            if (existingTicket.SeatId != ticketUpdate.SeatId)
            {
                var seatExists = await this.Seats.AnyAsync(s => s.SeatId == ticketUpdate.SeatId);
                if (!seatExists)
                {
                    throw new InvalidOperationException($"Seat with ID {ticketUpdate.SeatId} not found for update.");
                }

                var isNewSeatAlreadyTicketedInBooking = await this.Tickets
                                                                   .AnyAsync(t => t.BookingId == ticketUpdate.BookingId &&
                                                                                  t.SeatId == ticketUpdate.SeatId &&
                                                                                  t.TicketId != id);
                if (isNewSeatAlreadyTicketedInBooking)
                {
                    throw new InvalidOperationException($"Seat ID {ticketUpdate.SeatId} is already assigned a ticket within Booking ID {ticketUpdate.BookingId}.");
                }
            }

            existingTicket.BookingId = ticketUpdate.BookingId;
            existingTicket.SeatId = ticketUpdate.SeatId;

            this.Entry(existingTicket).State = EntityState.Modified;
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new TicketDTO
                {
                    TicketId = existingTicket.TicketId,
                    BookingId = existingTicket.BookingId,
                    SeatId = existingTicket.SeatId
                };
            }
            return null;
        }

        public async Task<bool> DeleteTicketAsync(int id)
        {
            var ticketToDelete = await this.Tickets.FindAsync(id);

            if (ticketToDelete == null)
            {
                return false;
            }

            this.Tickets.Remove(ticketToDelete);
            int savedChanges = await this.SaveChangesAsync();

            return savedChanges > 0;
        }
    }
}