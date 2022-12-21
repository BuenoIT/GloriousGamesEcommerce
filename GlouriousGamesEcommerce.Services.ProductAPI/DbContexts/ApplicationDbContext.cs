using GloriousGamesEcommerce.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace GlouriousGamesEcommerce.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
