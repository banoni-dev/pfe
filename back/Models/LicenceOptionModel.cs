using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class LicenseOptionModel
    {
        [Key]
        public int OptionId { get; set; }

        [ForeignKey("LicenseModel")]
        public int LicenseId { get; set; }

        [Required, MaxLength(100)]
        public string OptionName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; } = false;
    }
}
