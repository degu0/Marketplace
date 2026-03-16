using Backend.DTOs.User;
using Backend.Models.User;

namespace Backend.Services.User
{
    public interface IUserService
    {
        Task<UserResponseDto> CreatedUser(CreateUserDto dto);
        Task<UserResponseDto> GetById(string  id);

    }
}
