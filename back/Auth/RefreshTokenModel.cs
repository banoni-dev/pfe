
using System;

namespace back.Auth
{
    public class RefreshTokenModel
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
