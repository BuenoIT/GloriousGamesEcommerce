using AutoMapper;
using GloriousGames.Services.CouponAPI.Models;
using GloriousGames.Services.CouponAPI.Models.Dtos;

namespace GloriousGames.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
