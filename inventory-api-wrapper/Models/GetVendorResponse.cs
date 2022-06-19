namespace inventory_api_wrapper.Models;

public record GetVendorResponse
{
    public Guid VendorId { get; init; }
    public DateTime Created { get; init; }
    public string? Name { get; init; }
    public Uri? WebSite { get; init; }
}
