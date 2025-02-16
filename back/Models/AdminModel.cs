using System;
using Microsoft.AspNetCore.Identity;

namespace back.Models
{
    public enum AdminPrivilege
    {
        SuperAdmin,  // Has full control over all admins
        ManageAdmins, // Can add or verify admins
        ManageUsers,  // Can manage user accounts
    }

    public class AdminModel : IdentityUser
    {
        public AdminPrivilege Role { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
