namespace inventory_api_wrapper.Models;

public record PutVendorBody
{
    public Guid VendorId { get; init; }
    public string? Name { get; init; }
    public Uri? WebSite { get; init; }
}
