using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly BookingService bookingService;

        public BookingsController(BookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        
        [HttpGet("GetBookingByUser")]
        public async Task<ServiceResponse<IEnumerable<Booking>>> Get(int userId)
        {
            var bookings = await bookingService.GetAllBookingsByUser(userId);
            if (bookings.IsNullOrEmpty())
                return new ServiceResponse<IEnumerable<Booking>>(bookings, false);
            return new ServiceResponse<IEnumerable<Booking>>(bookings, true);
        }



        [HttpGet("GetBookingByEventShow")]
        public async Task<ServiceResponse<IEnumerable<Booking>>> GetBookingByShow(int showId)
        {
            var bookings = await bookingService.GetBookinsByEventShow(showId);
            if (bookings.IsNullOrEmpty())
                return new ServiceResponse<IEnumerable<Booking>>(bookings, false);
            return new ServiceResponse<IEnumerable<Booking>>(bookings, true);
        }

        [HttpGet("GetShows")]
        public async Task<List<Show>> GetShows(int eventId, int venueId)
        {
            var shows = await bookingService.GetShows(eventId, venueId);
            return shows;
        }


        [HttpGet("{id}")]
        public async Task<ServiceResponse<Booking?>> GetBooking(int id)
        {
           Booking? booking = await bookingService.GetBookingDetails(id);
            if (booking == null)
                return new ServiceResponse<Booking?>(null, false);
            return new ServiceResponse<Booking?>(booking, true);
        }

       

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await bookingService.DeleteBooking(id);
        }
    }
}
