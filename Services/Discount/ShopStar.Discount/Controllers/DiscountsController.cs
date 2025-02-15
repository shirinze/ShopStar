using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Discount.Dtos;
using ShopStar.Discount.Services;

namespace ShopStar.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var values=await _discountService.GetAllDiscountCouponListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var value = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto creatediscountCouponDto)
        {
            await _discountService.CreateDiscountCouponAsync(creatediscountCouponDto);
            return Ok("Create Success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Delete Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updatediscountCouponDto)
        {
            await _discountService.UpdateDiscountCouponAsync(updatediscountCouponDto);
            return Ok("Update Success");
        }
    }
}
