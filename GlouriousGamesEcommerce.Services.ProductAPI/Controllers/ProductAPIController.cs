using GloriousGamesEcommerce.Services.ProductAPI.Models.Dto;
using GloriousGamesEcommerce.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GloriousGamesEcommerce.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDto _responseDto;
        private IProductRepository _productRepository;

        public ProductAPIController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
