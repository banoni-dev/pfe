
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace back.Models
{
    public class SubscriptionTierModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; } // In days

        [Required]
        public int GracePeriod { get; set; } // In days

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
