using System.ComponentModel.DataAnnotations;

namespace inventory_api_wrapper.Models;

public class Products
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Title { get; set; }
    public string? Description { get; set; }
}
