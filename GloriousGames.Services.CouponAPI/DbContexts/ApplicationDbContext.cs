using GloriousGames.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GloriousGames.Services.CouponAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().HasData(
                new Coupon() { CouponId = 1, CouponCode = "10OFF", DiscountAmount = 10 },
                new Coupon() { CouponId = 2, CouponCode = "20OFF", DiscountAmount = 20 },
                new Coupon() { CouponId = 3, CouponCode = "30OFF", DiscountAmount = 30 }
                );
        }
    }
}
