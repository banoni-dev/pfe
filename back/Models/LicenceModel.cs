using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class LicenseModel
    {
        [Key]
        public int LicenseId { get; set; }

        [ForeignKey("ProductModel")]
        public int ProductId { get; set; }

        public int MaxDevices { get; set; }
        public int Duration { get; set; }
        public int GracePeriod { get; set; }

        public string PublicKey { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; } = false;
    }
}
