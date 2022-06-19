namespace inventory_api_wrapper.Models;

public record GetProductResponse
{
    public Guid ProductId { get; init; }
    public DateTime Created { get; init; }
    public string? Name { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
    public int Stock { get; init; }
    public int? ArticleNo { get; init; }
    public GetPriceResponse? Price { get; init; }
    public Guid? ProductTypeId { get; init; }
    public GetProductTypeResponse? ProductType { get; set; }
    public Guid? VendorId { get; init; }
    public GetVendorResponse? Vendor { get; set; }
}
