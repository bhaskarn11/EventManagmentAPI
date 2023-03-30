namespace EventManagment.Dtos
{
    public class UpdateUserDto
    {
        public int userId { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? HashedPassword { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
