using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class BlacklistedModel
    {
        [Key]
        public int BlockedId { get; set; }

        [Required, MaxLength(45)]
        public string Ip { get; set; }

        [Required, MaxLength(50)]
        public string Type { get; set; }

        public DateTime BlockedDate { get; set; }
        public DateTime? RecoveryDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateAt { get; set; } = DateTime.UtcNow;
    }
}
