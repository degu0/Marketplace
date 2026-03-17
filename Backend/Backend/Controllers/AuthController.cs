using Backend.DTOs.Auth;
using Backend.DTOs.User;
using Backend.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var response = await _authService.Login(loginDto);
            return Ok(response);
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(CreateUserDto userDto)
        {
            var response = await _authService.SignUp(userDto);
            return Ok(response);
        }


    }
}
