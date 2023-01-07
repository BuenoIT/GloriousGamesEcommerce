using System.ComponentModel.DataAnnotations;

namespace GloriousGamesEcommerce.Services.ShoppingCartAPI.Models
{
    public class CartHeaderDto
    {
        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
    }
}
