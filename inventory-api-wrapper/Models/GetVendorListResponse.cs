namespace inventory_api_wrapper.Models;

public record GetVendorListResponse 
{
    public int CurrentPage { get; init; } //Current Page
    public int PageSize { get; init; }  //Current Limit
    public int TotalItems { get; init; }
    public int TotalPages { get; init; }

    public List<GetVendorResponse> Items { get; init; }
    public IDictionary<LinkedResourceType, LinkedResource> Links { get; set; }
}
