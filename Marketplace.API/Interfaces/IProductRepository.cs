using Marketplace.API.Models;

namespace Marketplace.API.Interfaces;

public interface IProductRepository
{
    void AddProduct(Product product);
    List<Product> GetAllProducts();
    void DeleteProduct(int id);
}
