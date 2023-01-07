using GloriousGamesEcommerce.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GlouriousGamesEcommerce.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, Name = "Pokémon Violet", Price = 79.96, Description = "Embark on a new Pokémon adventure.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/1.jpg", CategoryName = "Switch" },
                new Product() { ProductId = 2, Name = "Hogwarts Legacy Deluxe", Price = 89.96, Description = "Hogwarts Legacy is an open-world action RPG set in the world introduced in the Harry Potter books.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/2.jpg", CategoryName = "Switch" },
                new Product() { ProductId = 3, Name = "Sonic Frontiers", Price = 79.96, Description = "Worlds are colliding in Sonic the Hedgehog's newest high-speed adventure!", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/3.jpg", CategoryName = "Switch" },
                new Product() { ProductId = 4, Name = "FIFA 23", Price = 49.96, Description = "Enjoy a more true-to-life football experience in FIFA 23 with new gameplay features that create risk-versus-reward shooting, new free kick, penalty, and corner mechanics, and more football variety.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/4.jpg", CategoryName = "Xbox One" },
                new Product() { ProductId = 5, Name = "Dying Light 2", Price = 39.95, Description = "Over twenty years ago in harran, we fought the virus—and lost. Now, we’re losing again.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/5.jpg", CategoryName = "Xbox One" },
                new Product() { ProductId = 6, Name = "Cyberpunk 2077", Price = 39.86, Description = "Cyberpunk 2077 has several updates planned for the new year that are planned to address a number of the issues that users have faced in the game.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/6.jpg", CategoryName = "Xbox One" },
                new Product() { ProductId = 7, Name = "Call Of Duty Modern Warfare 2", Price = 89.99, Description = "Witness what makes Task Force 141 the legendary squad it is today in Call of Duty: Modern Warfare II.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/7.jpg", CategoryName = "PS4" },
                new Product() { ProductId = 8, Name = "God of War Ragnarök", Price = 79.99, Description = "Embark on an epic and heartfelt journey as Kratos and Atreus struggle with holding on and letting go.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/8.jpg", CategoryName = "PS4" },
                new Product() { ProductId = 9, Name = "Final Fantasy VII Reunion", Price = 64.96, Description = "FINAL FANTASY VII – REUNION is a remaster of CRISIS CORE, featuring a complete HD graphics overhaul, remastered soundtrack, and an updated combat system.", ImageUrl = "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/9.jpg", CategoryName = "PS4" }
                );
        }
    }
}
