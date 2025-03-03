
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;



namespace back.Models
{

    public enum StatusEnum
    {
        Active,
        Inactive
    }

    public class LicensePurchaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserModel User { get; set; }

        [Required]
        [ForeignKey("License")]
        public int LicenseId { get; set; }
        public LicenseModel License { get; set; }

        [Required, MaxLength(500)]
        public string PublicKey { get; set; }

        [Required, MaxLength(500)]
        public string PrivateKey { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        [Required]
        public StatusEnum Status { get; set; }
    }
}

