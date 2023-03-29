namespace EventManagment.Models
{
    public class Show
    {

        public int Id { get; set; }

        public int EventId { get; set; }

        public int VenueId { get; set; }

        public DateTime ShowTime { get; set; }

        public int AvailableTickets { get; set; }

        public List<Seat>? Seats { get; set; } = default!;

    }
}