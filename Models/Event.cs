namespace EventManagment.Models
{
    public class Event
    {
        public int Id {get; set; }

        [Required]
        public string? Name {get; set; }
        public DateTime StartDate {get; set; }

        public DateTime EndDate {get; set; }

        public Regions EventRegion {get; set; }

        public int VenueId { get; set; }

        public ICollection<Venue>? Venue {get; set; }

        public ICollection<Review>? Reviews {get; set; }
    }
}