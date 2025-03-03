
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace back.Models
{
    public class FeatureModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("License")]
        public int LicenseId { get; set; }
        public LicenseModel License { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

