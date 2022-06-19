namespace inventory_api_wrapper.Models;

public record PostVendorBody
{
    public string? Name { get; init; }
    public Uri? WebSite { get; init; }
}
