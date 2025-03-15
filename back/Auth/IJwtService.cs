using System.Security.Claims;
using back.Models;

namespace back.Auth
{
    public interface IJwtService
    {
        string GenerateToken(UserModel user);
        string RefreshToken(string refreshToken);
        ClaimsPrincipal ValidateToken(string token);
    }
}
