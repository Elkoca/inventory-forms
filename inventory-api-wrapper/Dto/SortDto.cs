using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_api_wrapper.Dto;

public abstract record SortDto(string Property = "Created", SortingDirection SortDirection = SortingDirection.Ascending);

public enum SortingDirection
{
    Ascending,
    Descending
}

//public record SortProductDto() : SortBaseDto;
