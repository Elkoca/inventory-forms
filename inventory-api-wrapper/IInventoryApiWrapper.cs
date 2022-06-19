using inventory_api_wrapper.Dto;
using inventory_api_wrapper.Models;

namespace inventory_api_wrapper;

public interface IInventoryApiWrapper
{
    public Task<GetProductListResponse?> ListProduct();
    public Task<GetProductResponse?> GetProduct(Guid productId);
    public Task<GetProductResponse?> CreateProduct(PostProductBody newProduct);
    public Task UpdateProduct(PutProductBody replaceProduct);
    public Task DeleteProduct(Guid productId);
}
