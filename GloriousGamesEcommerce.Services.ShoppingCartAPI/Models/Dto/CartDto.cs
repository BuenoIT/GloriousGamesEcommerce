namespace GloriousGamesEcommerce.Services.ShoppingCartAPI.Models
{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; }
        public IEnumerable<CartDetails> CartDetails { get; set; }
    }
}
