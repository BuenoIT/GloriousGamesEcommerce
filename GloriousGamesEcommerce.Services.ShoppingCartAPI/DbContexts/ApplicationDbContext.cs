﻿using GloriousGamesEcommerce.Services.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GloriousGamesEcommerce.Services.ShoppingCartAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       public DbSet<Product> Products { get; set; }
       public DbSet<CartHeader> CartHeaders { get; set; }
       public DbSet<CartDetails> CartDetails { get; set; }

    }
}
