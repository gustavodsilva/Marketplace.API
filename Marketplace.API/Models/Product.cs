namespace Marketplace.API.Models;

public class Product
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEstoque { get; set; }
}
