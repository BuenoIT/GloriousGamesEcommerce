using GloriousGamesEcommerce.Services.ShoppingCartAPI.Models;

namespace GloriousGamesEcommerce.Services.ShoppingCartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartDto> GetCarByUserId(string userId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ClearCart(string userId);
    }
}
