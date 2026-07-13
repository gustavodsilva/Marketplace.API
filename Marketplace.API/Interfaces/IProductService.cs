using Marketplace.API.Models;

namespace Marketplace.API.Interfaces;

public interface IProductService
{
    Task AddProductAsync(Product product);
    Task<List<Product>> GetAllProductsAsync();
    Task<bool> DeleteProductAsync(int id);
}
