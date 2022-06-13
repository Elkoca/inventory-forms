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


    public async Task<Products?> ListProduct()
    {
        var request = new RestRequest("products");
        var response = await _client.GetAsync<Products>(request);
        return response;
    }
    public async Task<Products?> GetProduct(int id)
    {
        var request = new RestRequest($"products/{id}");
        var response = await _client.GetAsync<Products>(request);
        return response;
    }

    public async Task<Products?> CreateProduct(Products newProduct)
    {
        var request = new RestRequest("products");
        request.AddJsonBody<Products>(newProduct);
        var response = await _client.PostAsync<Products>(request);
        return response;
    }

    public async Task<Products?> UpdateProduct(Products newProduct)
    {
        var request = new RestRequest($"products/{newProduct.Id}");
        request.AddJsonBody<Products>(newProduct);
        var response = await _client.PutAsync<Products>(request);
        return response;
    }
    public async Task DeleteProduct(int id)
    {
        var request = new RestRequest($"products/{id}");
        var response = await _client.DeleteAsync(request);
        //return response.ResponseStatus;
        //throw new NotImplementedException();
    }
}