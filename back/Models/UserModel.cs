
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace back.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required, MaxLength(20)]
        public string CardId { get; set; }

        [Required, MaxLength(20)]
        public string CardPassword { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CardBalance { get; set; }
    }
}

//user(id, name, email, password,card_id,card_password,card_balance)

