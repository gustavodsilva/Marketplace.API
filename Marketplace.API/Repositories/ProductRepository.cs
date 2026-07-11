using Marketplace.API.Interfaces;
using Marketplace.API.Data;
using Marketplace.API.Models;

namespace Marketplace.API.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }
    public void DeleteProduct(int id)
    {
        var product = _context.Products.Find(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }

}