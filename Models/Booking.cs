using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManagment.Models
{
    class Booking
    {
        public int Id {get; set;}

        public User? User {get; set;}

        [Required]
        public DateTime BookingDate {get; set;}

        [Required]
        public Event? BookingItem {get; set; }

        public DateTime EventDate {get; set;}
        public int TotalTickets {get; set;}

    }
}