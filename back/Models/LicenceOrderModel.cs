using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class LicenseOrderModel
    {
        public enum StatusEnum
        {
            Active,
            Inactive,
            Suspended,
            Canceled
        }

        [Key]
        public int LicenseOrderId { get; set; }

        [ForeignKey("UserModel")]
        public int UserId { get; set; }

        [ForeignKey("LicenseModel")]
        public int LicenseId { get; set; }

        public string PrivateKey { get; set; }

        public DateTime PurchaseDate { get; set; }

        [Required]
        public string StatusEnum { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; } = false;
    }
}
