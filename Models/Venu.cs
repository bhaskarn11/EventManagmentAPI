namespace EventManagment.Models
{
    public class Venue
    {
        public int Id {get; set;}

        public string? Name {get; set;}

        public Regions VenueRegion {get; set;}

        public decimal? Lat {get; set;}
        public decimal? Lng {get; set;}

        [Required]
        public string? Address {get; set;}

        public ICollection<Review>? Reviews { get; set; }

        public ICollection<Event>? Events { get; set; }
    }
}