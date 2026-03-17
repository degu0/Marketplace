namespace Backend.DTOs.User
{
    public class UserResponseDto
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role {  get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
