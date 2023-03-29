namespace EventManagment.Services.Interfaces
{
	public interface IBookingService
	{
		public Booking CreateBooking();
		public List<Booking> GetAllBookingsByUser();
		public Booking? GetBookingDetails();

		public List<Show>? GetShows();
		public List<Booking>? GetBookinsByEventShow();
		public List<Seat>? GetSeatsByShow();

	}
}
