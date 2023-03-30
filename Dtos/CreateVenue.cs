namespace EventManagment.Dtos
{
    public class CreateVenue
    {
        public string? Name { get; set; }

        public Regions VenueRegion { get; set; }

        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }

        [Required]
        public string? Address { get; set; }
    }
}
