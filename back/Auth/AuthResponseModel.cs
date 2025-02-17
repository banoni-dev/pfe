
namespace back.Auth
{
    public class AuthResponseModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string TokenType { get; set; } = "Bearer";
    }
}
