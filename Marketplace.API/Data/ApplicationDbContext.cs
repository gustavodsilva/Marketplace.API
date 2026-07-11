using Microsoft.EntityFrameworkCore;
using Marketplace.API.Models;

namespace Marketplace.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
}
