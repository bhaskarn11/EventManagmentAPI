namespace EventManagment.Models
{
    public class User
    {
        public int Id {get; set;}

        public string? Name {get; set;}

        public string? Email {get; set;}

        public string? HashedPassword {get; set;}

        public string? PhoneNumber {get; set;}

        public UserTypes UserType {get; set;}
        public ICollection<Review>? Reviews { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }

    public enum UserTypes
    {
        ADMIN,
        CUSTOMER,
        ORGANIZER
    }
}