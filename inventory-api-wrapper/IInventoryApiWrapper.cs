using inventory_api_wrapper.Models;

namespace inventory_api_wrapper;

public interface IInventoryApiWrapper
{
    public Task<Products?> ListProduct();
    public Task<Products?> GetProduct(int id);
    public Task<Products?> CreateProduct(Products newProduct);
    public Task<Products?> UpdateProduct(Products newProduct);
    public Task DeleteProduct(int id);
}
