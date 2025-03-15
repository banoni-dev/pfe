using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class SubscriptionOrderModel
    {
        public enum StatusEnum
        {
            Active,
            Inactive,
            Suspended,
            Canceled
        }

        [Key]
        public int SubscriptionOrderId { get; set; }

        [ForeignKey("SubscriptionTierModel")]
        public int SubscriptionTierId { get; set; }

        [ForeignKey("UserModel")]
        public int UserId { get; set; }

        public DateTime PurchaseDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public StatusEnum Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;

        public bool IsArchived { get; set; } = false;
    }
}
