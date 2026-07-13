using Microsoft.AspNetCore.Mvc;
using Marketplace.API.Models;
using Marketplace.API.Interfaces;

namespace Marketplace.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<IActionResult> CriarProduto([FromBody] Product product)
    {
        try
        {
            await _productService.AddProductAsync(product);
            return Ok("Produto adicionado com sucesso.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> ListarProdutos()
    {
        var products = await _productService.GetAllProductsAsync();
        return Ok(products);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> ExcluirProduto(int id)
    {
        var deleted = await _productService.DeleteProductAsync(id);
        if (!deleted)
        {
            return NotFound("Produto não encontrado.");
        }
        return Ok("Produto excluído com sucesso.");
    }
}