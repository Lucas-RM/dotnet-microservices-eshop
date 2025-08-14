using EshopMicroservices.ProductApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EshopMicroservices.ProductApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
