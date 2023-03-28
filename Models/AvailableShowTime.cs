namespace EventManagment.Models
{
    class AvailableShowTime
    {
        public int eventId {get; set;}

        public int venueId {get; set;}

        public DateTime ShowTime {get; set;}

        public int availableTickets {get; set;}
    }
}