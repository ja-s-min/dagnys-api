using dagnys_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace dagnys_api.Data;

    
    public class DataContext : DbContext
{
    public DbSet<Product>Products { get; set; }
    public DbSet<Supplier>Suppliers { get; set; }
    public DbSet<Recipe>Recipes { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }    
}
