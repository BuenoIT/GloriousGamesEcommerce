using GloriousGames.Services.CouponAPI.Models.Dtos;

namespace GloriousGames.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
