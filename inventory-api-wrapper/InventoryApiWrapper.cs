using RestSharp;
using inventory_api_wrapper.Models;

namespace inventory_api_wrapper;

public class InventoryApiWrapper : IInventoryApiWrapper
{
    private string _baseUrl;
    private RestClient _client;

    public InventoryApiWrapper()
    {
        _baseUrl = "https://localhost:7156/api";
        _client = new RestClient(_baseUrl);
    }


    public async Task<GetProductListResponse?> ListProduct()
    {
        var request = new RestRequest("products");
        var response = await _client.GetAsync<GetProductListResponse>(request);
        return response;
    }
    public async Task<GetProductResponse?> GetProduct(Guid productId)
    {
        var request = new RestRequest($"products/{productId}");
        var response = await _client.GetAsync<GetProductResponse>(request);
        return response;
    }

    public async Task<GetProductResponse?> CreateProduct(PostProductBody newProduct)
    {
        var request = new RestRequest("products");
        request.AddJsonBody(newProduct);
        var response = await _client.PostAsync<GetProductResponse>(request);
        return response;
    }

    public async Task UpdateProduct(PutProductBody replaceProduct)
    {
        var request = new RestRequest($"products/{replaceProduct.ProductId}");
        request.AddJsonBody(replaceProduct);
        await _client.PutAsync(request);
    }
    public async Task DeleteProduct(Guid productId)
    {
        var request = new RestRequest($"products/{productId}");
        await _client.DeleteAsync(request);
    }
}