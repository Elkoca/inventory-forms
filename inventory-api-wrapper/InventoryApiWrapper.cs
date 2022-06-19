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

    #region Products
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
    #endregion

    #region Vendor
    public async Task<GetVendorListResponse?> ListVendor()
    {
        var request = new RestRequest("vendors");
        var response = await _client.GetAsync<GetVendorListResponse>(request);
        return response;
    }
    public async Task<GetVendorResponse?> GetVendor(Guid vendorId)
    {
        var request = new RestRequest($"vendors/{vendorId}");
        var response = await _client.GetAsync<GetVendorResponse>(request);
        return response;
    }

    public async Task<GetVendorResponse?> CreateVendor(PostVendorBody newVendor)
    {
        var request = new RestRequest("vendors");
        request.AddJsonBody(newVendor);
        var response = await _client.PostAsync<GetVendorResponse>(request);
        return response;
    }

    public async Task UpdateVendor(PutVendorBody replaceVendor)
    {
        var request = new RestRequest($"vendors/{replaceVendor.VendorId}");
        request.AddJsonBody(replaceVendor);
        await _client.PutAsync(request);
    }
    public async Task DeleteVendor(Guid vendorId)
    {
        var request = new RestRequest($"vendors/{vendorId}");
        await _client.DeleteAsync(request);
    }
    #endregion

    #region ProductType
    public async Task<GetProductTypeListResponse?> ListProductType()
    {
        var request = new RestRequest("productTypes");
        var response = await _client.GetAsync<GetProductTypeListResponse>(request);
        return response;
    }
    public async Task<GetProductTypeResponse?> GetProductType(Guid productTypeId)
    {
        var request = new RestRequest($"productTypes/{productTypeId}");
        var response = await _client.GetAsync<GetProductTypeResponse>(request);
        return response;
    }

    public async Task<GetProductTypeResponse?> CreateProductType(PostProductTypeBody newProductType)
    {
        var request = new RestRequest("productTypes");
        request.AddJsonBody(newProductType);
        var response = await _client.PostAsync<GetProductTypeResponse>(request);
        return response;
    }

    public async Task UpdateProductType(PutProductTypeBody replaceProductType)
    {
        var request = new RestRequest($"productTypes/{replaceProductType.ProductTypeId}");
        request.AddJsonBody(replaceProductType);
        await _client.PutAsync(request);
    }
    public async Task DeleteProductType(Guid productTypeId)
    {
        var request = new RestRequest($"productTypes/{productTypeId}");
        await _client.DeleteAsync(request);
    }
    #endregion
}