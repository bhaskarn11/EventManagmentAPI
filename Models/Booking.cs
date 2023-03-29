namespace EventManagment.Models
{
    public class Booking
    {
        public int Id {get; set;}

        public User? User {get; set;}

        public DateTime BookingDate {get; set;}

        public Show? Show { get; set; }

        public string? EventName {get; set; }

        public string? VenueName { get; set; }

        public DateTime ShowTime {get; set;}
        public int TotalTicketCount {get; set;}

        public string? Seats { get; set; }

        public decimal TotalTicketPrice { get; set; }

    }
}