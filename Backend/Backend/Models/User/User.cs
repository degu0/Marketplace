using Backend.Domain.Enum;
using Microsoft.AspNetCore.Identity;

namespace Backend.Models.User
{
    public class User : IdentityUser
    {
        public UserRole Role { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
