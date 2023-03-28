namespace EventManagment.Models
{
    class User
    {
        public int Id {get; set;}

        public string? Name {get; set;}

        public string? Email {get; set;}

        public string? HashedPassword {get; set;}

        public string? PhoneNumber {get; set;}

        public UserTypes UserType {get; set;}
    }

    enum UserTypes
    {
        ADMIN,
        CUSTOMER,
        ORGANIZER
    }
}