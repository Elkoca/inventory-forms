namespace inventory_api_wrapper.Models;

public record LinkedResource(string Href);

public enum LinkedResourceType
{
    None,
    First,
    Last,
    Prev,
    Next
}
