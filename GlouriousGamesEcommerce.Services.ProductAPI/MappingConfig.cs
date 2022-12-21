using AutoMapper;
using GloriousGamesEcommerce.Services.ProductAPI.Models;
using GloriousGamesEcommerce.Services.ProductAPI.Models.Dto;

namespace GloriousGamesEcommerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
