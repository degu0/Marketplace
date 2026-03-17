namespace Backend.DTOs.Auth
{
    public class TokenResponseDto
    {
        public string Token { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
        public string UserName { get; set; } = null!;
        public string Role {  get; set; } = null!;
    }
}
