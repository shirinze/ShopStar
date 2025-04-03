using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Catalog.Dtos.ProductDetailDtos;
using ShopStar.Catalog.Services.ProductDetailServices;

namespace ShopStar.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _productDetailService;

        public ProductDetailsController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductDetailList()
        {
            var values = await _productDetailService.GetAllProductDetailListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(string id)
        {
            var value = await _productDetailService.GetByIdProductDetailAsync(id);
            return Ok(value);
        }
        [HttpGet("GetByProductIdProductDetail")]
        public async Task<IActionResult> GetByProductIdProductDetail(string id)
        {
            var value = await _productDetailService.GetByProductIdProductDetailAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetaildto)
        {
            await _productDetailService.CreateProductDetailAsync(createProductDetaildto);
            return Ok("Create Success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _productDetailService.DeleteProductDetailAsync(id);
            return Ok("Delete Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetaildto)
        {
            await _productDetailService.UpdateProductDetailAsync(updateProductDetaildto);
            return Ok("Update Success");
        }
    }
}
