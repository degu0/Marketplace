using Backend.Domain.Enum;

namespace Backend.DTOs.User
{
    public class CreateUserDto
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public UserRole Role { get; set; }
    }
}
