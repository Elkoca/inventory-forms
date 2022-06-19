namespace inventory_api_wrapper.Models;

public record PutProductTypeBody
{
    public Guid ProductTypeId { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
}
