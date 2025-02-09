
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;



namespace back.Models
{

    public enum SubscriptionStatus
    {
        PAID,
        UNPAID,
    }


    public class SubscriptionModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public UserModel User { get; set; }

        [Required]
        public int TierId { get; set; }
        [ForeignKey("TierId")]
        public TierModel Tier { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime NextDueDate { get; set; }

        [Required, MaxLength(20)]
        public SubscriptionStatus Status { get; set; }

        [Required]
        public int DeviceCount { get; set; }

        [Required, MaxLength(255)]
        public string Key { get; set; }
    }
}
