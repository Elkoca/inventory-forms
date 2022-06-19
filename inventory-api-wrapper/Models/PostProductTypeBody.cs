namespace inventory_api_wrapper.Models;

public record PostProductTypeBody
{
    public string? Name { get; init; }
    public string? Description { get; init; }
}
