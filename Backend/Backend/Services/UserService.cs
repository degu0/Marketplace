using Backend.DTOs.User;
using UserModel = Backend.Models.User.User;
using Backend.Services.User;
using Microsoft.AspNetCore.Identity;


namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserModel> _userManager;

        public UserService(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<UserResponseDto> CreatedUser(CreateUserDto dto)
        {
            var user = new UserModel { UserName = dto.UserName, Email = dto.Email };
            await _userManager.CreateAsync(user, dto.Password);
            await _userManager.AddToRoleAsync(user, dto.Role.ToString());

            return new UserResponseDto
            {
                Id = user.Id,
                UserName = user.UserName!,
                Email = user.Email!,
                Role = dto.Role.ToString(),
                CreatedAt = user.CreatedAt
            };
        }

        public async Task<UserResponseDto> GetById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                throw new KeyNotFoundException("User not found");

            return new UserResponseDto
            {
                Id = user.Id,
                UserName = user.UserName!,
                Email = user.Email!,
                CreatedAt = user.CreatedAt
            };
        }
    }
}
