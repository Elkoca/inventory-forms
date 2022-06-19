using inventory_api_wrapper.Dto;
using inventory_api_wrapper.Models;

namespace inventory_api_wrapper;

public interface IInventoryApiWrapper
{
    #region Products
    public Task<GetProductListResponse?> ListProduct();
    public Task<GetProductResponse?> GetProduct(Guid productId);
    public Task<GetProductResponse?> CreateProduct(PostProductBody newProduct);
    public Task UpdateProduct(PutProductBody replaceProduct);
    public Task DeleteProduct(Guid productId);
    #endregion

    #region Vendors
    public Task<GetVendorListResponse?> ListVendor();
    public Task<GetVendorResponse?> GetVendor(Guid vendorId);
    public Task<GetVendorResponse?> CreateVendor(PostVendorBody newVendor);
    public Task UpdateVendor(PutVendorBody replaceVendor);
    public Task DeleteVendor(Guid vendorId);
    #endregion

    #region ProductTypes
    public Task<GetProductTypeListResponse?> ListProductType();
    public Task<GetProductTypeResponse?> GetProductType(Guid productTypeId);
    public Task<GetProductTypeResponse?> CreateProductType(PostProductTypeBody newProductType);
    public Task UpdateProductType(PutProductTypeBody replaceProductType);
    public Task DeleteProductType(Guid productTypeId);

    #endregion

}
