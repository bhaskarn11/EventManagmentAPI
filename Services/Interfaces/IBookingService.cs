using EventManagment.Dtos;

namespace EventManagment.Services.Interfaces
{
	public interface IBookingService
	{
		public Task<Booking?> CreateBooking(CreateBooking createBooking);
		public Task<List<Booking>> GetAllBookingsByUser(int userId);
		public Task<Booking?> GetBookingDetails(int bookingId);

		public Task<List<Show>> GetShows(int eventId, int venueId);
		public Task<List<Booking>> GetBookinsByEventShow(int showId);
		public Task<List<Seat>> GetSeatsByShow(int showId);

		public Task<int> DeleteBooking(int bookingId);

	}
}
