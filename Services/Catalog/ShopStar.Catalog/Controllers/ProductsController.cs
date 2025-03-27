using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Catalog.Dtos.ProductDtos;
using ShopStar.Catalog.Services.ProductServices;


namespace ShopStar.Catalog.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var values = await _productService.GetProductListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var value = await _productService.GetByIdProductAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductdto)
        {
            await _productService.CreateProductAsync(createProductdto);
            return Ok("Create Success");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Delete Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductdto)
        {
            await _productService.UpdateProductAsync(updateProductdto);
            return Ok("Update Success");
        }
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values=await _productService.GetProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ProductWithCategoryByCategoryId")]
        public async Task<IActionResult> ProductWithCategoryByCategoryId(string CategoryId)
        {
            var value = await _productService.GetProductWithCategoryByCategoryIdAsync(CategoryId);
            return Ok(value);
        }
    }
}
