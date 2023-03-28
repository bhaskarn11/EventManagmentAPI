using System.ComponentModel.DataAnnotations;

namespace EventManagment.Models
{
    class Event
    {
        public int Id {get; set;}

        [Required]
        public string? Name {get; set;}
        public DateTime StartDate {get; set;}

        public DateTime EndDate {get; set;}

        [Required]
        public Regions EventRegion {get; set;}

        [Required]
        public ICollection<Venue>? Venue {get; set;}

        public ICollection<Review>? Reviews {get; set;}
    }
}