using CatalogueService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogueService.Repository
{
    public class CatalogueDbContext : DbContext
    {
        public CatalogueDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Produit> Produits;
        public DbSet<Categorie> Categories;
    }
}
