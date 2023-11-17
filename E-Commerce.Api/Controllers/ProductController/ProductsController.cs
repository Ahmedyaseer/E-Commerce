using E_Commerce.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Api.Controllers.ProductController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductManager productManager;

        public ProductsController(IProductManager productManager)
        {
            this.productManager = productManager;
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var products = productManager.GetAllProductsDto();
            return Ok(products);

        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetProduct(int id)
        {
            var product = productManager.GetProductByIdDto(id);
            return Ok(product);
        }
       
    }
}
