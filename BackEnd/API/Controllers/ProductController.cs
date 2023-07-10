using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        [HttpPost("api/product/add")]
        public IActionResult Add(Product product)
        {
            return Ok(_productService.Add(product));
        }
        [HttpPost("api/product/update")]
        public IActionResult Update(Product product)
        {
            return Ok(_productService.Update(product));
        }
        [HttpPost("api/product/delete")]
        public IActionResult Delete(Product product)
        {
            _productService.Delete(product);
            return Ok(product);
        }
        [HttpGet("api/product/getall")]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet("api/product/getbyid")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }
        [HttpGet("api/product/getbycategory/{categoryId}/{skip}/{take}")]
        public IActionResult GetProductsByCategory(int categoryId, int skip, int take)
        {
            return Ok(_productService.GetProductsByCategory(categoryId, skip, take));
        }
    }
}
