using Microsoft.AspNetCore.Mvc;
using back.Auth;
using back.Models;
using System;

namespace back.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        // POST: api/auth/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestModel loginRequest)
        {
            try
            {
                // just for testing now
                var user = new UserModel
                {
                    Id = 1,
                    Email = loginRequest.Email,
                    FirstName = "First",
                    LastName = "Last",
                    Password = "hashedPassword"
                };

                var token = _jwtService.GenerateToken(user);
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // POST: api/auth/refresh
        [HttpPost("refresh")]
        public IActionResult RefreshToken([FromBody] RefreshTokenModel refreshTokenRequest)
        {
            try
            {
              // TODO: implement refresh token logic
              return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
