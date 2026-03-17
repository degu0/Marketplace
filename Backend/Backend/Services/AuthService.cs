using Backend.DTOs.Auth;
using UserModel = Backend.Models.User.User;
using Backend.Services.Auth;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Backend.DTOs.User;

namespace Backend.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthService(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<TokenResponseDto> Login(LoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user == null)
                throw new UnauthorizedAccessException("Email or password invalid");

            var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);

            if(!result.Succeeded)
                throw new UnauthorizedAccessException("Email or password invalid");

            var roles = await _userManager.GetRolesAsync(user);
            var expiresAt = DateTime.UtcNow.AddHours(8);
            var token = GenerateToken(user, roles, expiresAt);

            return new TokenResponseDto
            {
                Token = token,
                ExpiresAt = expiresAt,
                UserName = user.UserName!,
                Role = roles.FirstOrDefault() ?? "Customer"
            };
        }

        public async Task<TokenResponseDto> SignUp(CreateUserDto dto)
        {
            var existingUser = await _userManager.FindByEmailAsync(dto.Email);

            if (existingUser != null)
                throw new InvalidOperationException("Email exists");

            var user = new UserModel
            {
                UserName = dto.UserName,
                Email = dto.Email,
            };

            var result = await _userManager.CreateAsync(user, dto.Password);
            
            if(!result.Succeeded) 
                throw new InvalidOperationException(result.Errors.First().Description);

            await _userManager.AddToRoleAsync(user, dto.Role.ToString());

            var roles = await _userManager.GetRolesAsync(user);
            var expiresAt = DateTime.UtcNow.AddHours(8);
            var token = GenerateToken(user, roles, expiresAt);

            return new TokenResponseDto
            {
                Token = token,
                ExpiresAt = expiresAt,
                UserName = user.UserName!,
                Role = roles.FirstOrDefault() ?? "Customer"
            };

        }

        private string GenerateToken(UserModel user, IList<string> roles, DateTime expiresAt)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
            };

            foreach (var role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!));

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expiresAt,
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
