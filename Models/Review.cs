namespace EventManagment.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Body { get; set; }

        public DateTime PublishDate { get; set; }

        public int Rating { get; set; }

        public User? User { get; set; }
        public Event? Event { get; set; }
        public Venue? Venue { get; set; }

    }
}