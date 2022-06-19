namespace inventory_api_wrapper.Models;

public record PostPriceBody
{
    public string? Code { get; init; } // USD, NOK
    public double? Amount { get; init; } // 4999,99
}
