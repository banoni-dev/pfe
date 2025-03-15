using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class SubscriptionTierModel
    {
        [Key]
        public int TierId { get; set; }

        [ForeignKey("ProductModel")]
        public int ProductId { get; set; }

        [Required, MaxLength(100)]
        public string TierName { get; set; }

        public int Duration { get; set; }
        public int GracePeriod { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; } = false;
    }
}
