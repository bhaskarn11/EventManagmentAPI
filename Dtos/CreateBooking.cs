namespace EventManagment.Dtos
{
    public class CreateBooking
    {
        [Required]
        public string? EventName { get; set; }

        [Required]
        public string? VenueName { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ShowId { get; set; }

        public List<SelectSeat> SelectedSeats { get; set; }
        
    }
}
