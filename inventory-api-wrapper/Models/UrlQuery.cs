using System.ComponentModel.DataAnnotations;

namespace inventory_api_wrapper.Models;

public abstract record UrlQueryPagingBase()
{
    [Range(1, Double.MaxValue)]
    public int Limit { get; init; } = 25;
    [Range(1, int.MaxValue)]
    public int Page { get; init; } = 1;
    public string? SortBy { get; init; }
};

public record UrlQueryGetProductList(string? Search) : UrlQueryPagingBase;
public record UrlQueryGetProductTypeList() : UrlQueryPagingBase;
public record UrlQueryGetVendorList() : UrlQueryPagingBase;