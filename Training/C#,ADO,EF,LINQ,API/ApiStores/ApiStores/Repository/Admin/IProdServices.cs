using ApiStores.Models;

namespace ApiStores.Repository.Admin
{
    public interface IProdServices
    {
        Task<List<ProductDatum>?> GetProductData();
        Task<ProductDatum>? GetProductDatum(string id);
        Task<List<ProductDatum>?> PutProduct(string id, ProductDatum productDatum);
        Task<List<ProductDatum>> PostProductDatum(ProductDatum productDatum);
        Task<List<ProductDatum>> DeleteProductdatum(string id);
    }
}
