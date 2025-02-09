using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using back.Models;

//session(id, #user_id, #subscription_id, device_print)

namespace back.Models
{
    public class SessionModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public UserModel User { get; set; }

        [Required]
        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public SubscriptionModel Subscription { get; set; }

        [Required, MaxLength(255)]
        public string DevicePrint { get; set; }
    }
}
