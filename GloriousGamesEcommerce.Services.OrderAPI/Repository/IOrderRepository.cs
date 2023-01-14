using GloriousGamesEcommerce.Services.OrderAPI.Models;

namespace GloriousGamesEcommerce.Services.OrderAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader orderHeader);
        Task UpdateOrderPaymentStatus(int orderHeaderId, bool paid);
    }
}
