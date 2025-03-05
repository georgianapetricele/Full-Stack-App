﻿namespace Backend.Models
{
    public class Contact
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string PhoneNumber { get; set; }
        public bool Favourite { get; set; }
    }
}
