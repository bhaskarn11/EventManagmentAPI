namespace EventManagment.Models
{
    public class Seat
    {

        public int Id { get; set; }
        public string? Class { get; set; }
        public string? Row { get; set; }
        public int EventId { get; set; }
        public int VenueId { get; set; }

        [ForeignKey("Show")]
        public int ShowId { get; set; }

        public int Price { get; set; }
    }
}