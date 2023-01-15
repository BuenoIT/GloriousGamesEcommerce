using GloriousGamesEcommerce.Services.ShoppingCartAPI.Models.Dto;

namespace GloriousGamesEcommerce.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
