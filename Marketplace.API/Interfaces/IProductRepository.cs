using Marketplace.API.Models;

namespace Marketplace.API.Interfaces;

public interface IProductRepository
{
    Task AddProductAsync(Product product);
    Task<List<Product>> GetAllProductsAsync();
    Task<bool> DeleteProductAsync(int id);
}
