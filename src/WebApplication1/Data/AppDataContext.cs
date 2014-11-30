using Microsoft.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptions builder)
        {
            builder.UseInMemoryStore();
        }
    }
}