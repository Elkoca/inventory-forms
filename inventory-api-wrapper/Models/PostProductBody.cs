using System.ComponentModel.DataAnnotations;

namespace inventory_api_wrapper.Models;

public record PostProductBody
{
    [Required]
    public string Name { get; init; }
    [Required]
    public string Title { get; init; }
    public string? Description { get; init; }
    [Required]
    public int Stock { get; init; } //Antal varer
    public int? ArticleNo { get; init; } //Barcode
    public PostPriceBody? Price { get; init; }
    public Guid? ProductTypeId { get; init; }
    public Guid? VendorId { get; init; }
}
