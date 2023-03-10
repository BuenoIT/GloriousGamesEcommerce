using GloriousGamesEcommerce.Services.ShoppingCartAPI.Models.Dto;

namespace GloriousGamesEcommerce.Services.ShoppingCartAPI.Models
{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; }
        public IEnumerable<CartDetailsDto> CartDetails { get; set; }
    }
}
