
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace back.Models
{

    public enum StatusEnum
    {
        ACTIVE,
        INACTIVE,
        CANCELLED,
    }
    

    public class SubscriptionPurchaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserModel User { get; set; }

        [Required]
        [ForeignKey("SubscriptionTier")]
        public int SubscriptionTierId { get; set; }
        public SubscriptionTierModel SubscriptionTier { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public StatusEnum Status { get; set; }
    }
}
