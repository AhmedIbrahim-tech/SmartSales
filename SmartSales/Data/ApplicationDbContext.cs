using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartSales.Models;

namespace SmartSales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Campany> Campany { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}