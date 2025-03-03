
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;



namespace back.Models
{
    public class LicenseFeaturePurchaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("LicensePurchase")]
        public int LicensePurchaseId { get; set; }
        public LicensePurchaseModel LicensePurchase { get; set; }

        [Required]
        [ForeignKey("Feature")]
        public int FeatureId { get; set; }
        public FeatureModel Feature { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
    }
}

