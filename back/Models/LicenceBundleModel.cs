using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class LicenseBundleModel
    {
        [Key]
        public int LicenseBundleId { get; set; }

        [ForeignKey("LicenseOrderModel")]
        public int LicenseOrderId { get; set; }

        [ForeignKey("LicenseOptionModel")]
        public int OptionId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;
    }
}
