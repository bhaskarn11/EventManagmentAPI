namespace EventManagment.Dtos
{
    public class EventDto
    {
        public string? Name { get; set; }
        public Regions EventRegion { get; set; }

        public int VenueId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
