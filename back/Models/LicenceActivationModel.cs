using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class LicenseActivationModel
    {
        [Key]
        public int ActivationId { get; set; }

        [ForeignKey("LicenseOrderModel")]
        public int LicenseOrderId { get; set; }

        [Required, MaxLength(100)]
        public string DeviceFingerprint { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; } = false;
    }
}
