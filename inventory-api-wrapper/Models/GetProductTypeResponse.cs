namespace inventory_api_wrapper.Models;

public record GetProductTypeResponse
{
    public Guid ProductTypeId { get; init; }
    public DateTime Created { get; init; }
    public string? Name { get; init; }
    public string? Description { get; init; }
}
