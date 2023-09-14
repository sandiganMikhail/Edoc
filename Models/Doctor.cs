using Microsoft.AspNetCore.Identity;

namespace Edoc.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public int SpecializationId { get; set; }

        public Specialization? Specialization { get; set; }
    }
}
