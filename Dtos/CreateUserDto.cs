﻿namespace EventManagment.Dtos
{
    public class CreateUserDto
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? HashedPassword { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
