using Backend.DTOs.Auth;
using Backend.DTOs.User;

namespace Backend.Services.Auth
{
    public interface IAuthService
    {
        Task<TokenResponseDto> Login(LoginDto dto);
        Task<TokenResponseDto> SignUp(CreateUserDto dto);
    }
}
