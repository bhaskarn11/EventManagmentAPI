using EventManagment.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EventManagment.Services
{
	public class BookingService : IBookingService
	{
		private readonly AppDbContext _context;
		public BookingService(AppDbContext context)
		{
			_context = context;
		}


		public async Task<Booking>? CreateBooking(CreateBooking createBooking)
		{

			
			/*Seat[] availableSeats = await _context.Seats
													.Where(p => p.ShowId == createBooking.ShowId)
													.ToArrayAsync();

            for(int i=0;i < availableSeats.Length; i++)
            {
                if (createBooking.SelectedSeats.IsNullOrEmpty())
                    throw new Exception("No seat selected");

                if (availableSeats[i].Row[] != createBooking.SelectedSeats[i].Row)
					throw new Exception("Ticket state BOOKED");
            }*/

            Booking booking = new() {
				BookingDate=DateTime.UtcNow,

			};
			_context.Bookings.Add(booking);
			await _context.SaveChangesAsync();
			return booking;
		}

		public async Task<List<Booking>>? GetAllBookingsByUser(int userId)
		{
			User? user = await _context.Users.Where(p => p.Id == userId).FirstOrDefaultAsync();

            return user == null ? throw new Exception("User not found") : await _context.Bookings.Where(p => p.User!.Id == user.Id).ToListAsync();
        }

        public async Task<Booking>? GetBookingDetails(int bookingId)
		{
			Booking? bookingDetails = await _context.Bookings.Where(p => p.Id == bookingId).FirstOrDefaultAsync();
            if (bookingDetails == null)
            {
				throw new Exception("No result found");
            }

			return bookingDetails;
        }

		public async Task<List<Booking>>? GetBookinsByEventShow(int showId)
		{
			return await _context.Bookings.Where(p => p.ShowId == showId).ToListAsync();
		}

		public async Task<List<Seat>>? GetSeatsByShow(int showId)
		{
			return await _context.Seats.Where(p => p.ShowId == showId).ToListAsync();
		}

		public async Task<List<Show>>? GetShows(int eventId, int venueId)
		{
			return await _context.Shows.Where(p => p.EventId == eventId && p.VenueId == venueId).ToListAsync();
		}
	}
}
