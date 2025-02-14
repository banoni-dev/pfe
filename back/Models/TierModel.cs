using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
public class TierModel
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required, Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    public int MaxDevices { get; set; }

    [Required]
    public int Duration { get; set; }
    [Required]
    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    public ProductModel? Product { get; set; } 
}
}
