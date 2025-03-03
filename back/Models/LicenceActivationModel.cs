
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace back.Models
{
    public class LicenseActivationModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("LicensePurchase")]
        public int LicensePurchaseId { get; set; }
        public LicensePurchaseModel LicensePurchase { get; set; }

        [Required, MaxLength(255)]
        public string DeviceFingerprint { get; set; }

        [Required]
        public DateTime ActivationDate { get; set; } = DateTime.UtcNow;
    }
}

