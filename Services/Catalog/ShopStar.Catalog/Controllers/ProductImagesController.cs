using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Catalog.Dtos.ProductImageDtos;
using ShopStar.Catalog.Services.ProductImageServices;

namespace ShopStar.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductImageList()
        {
            var values = await _productImageService.GetAllProductImageListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var value = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImagedto)
        {
            await _productImageService.CreateProductImageAsync(createProductImagedto);
            return Ok("Create Success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Delete Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImagedto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImagedto);
            return Ok("Update Success");
        }
        [HttpGet("GetByProductIdProductImage")]
        public async Task<IActionResult> GetByProductIdProductImage(string id)
        {
            var value = await _productImageService.GetByProductIdProductImageAsync(id);
            return Ok(value);
        }
    }
}
