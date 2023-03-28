namespace EventManagment.Models
{
    class Review
    {
        public int Id { get; set; }
        public string? Body { get; set; }

        public DateTime PublishDate { get; set; }

        public int Rating { get; set; }


    }
}