using Marketplace.API.Interfaces;
using Marketplace.API.Models;

namespace Marketplace.API.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    public async Task AddProductAsync(Product product)
    {
        if (product.Preco <= 0)
        {
            throw new ArgumentException("Preço do produto não pode ser menor ou igual a zero.");
        }
        if (string.IsNullOrWhiteSpace(product.Nome))
        {
            throw new ArgumentException("Nome do produto não pode ser nulo.");
        }
        await _repository.AddProductAsync(product);
    }
    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _repository.GetAllProductsAsync();
    }
    public async Task<bool> DeleteProductAsync(int id)
    {
        return await _repository.DeleteProductAsync(id);
    }
}
