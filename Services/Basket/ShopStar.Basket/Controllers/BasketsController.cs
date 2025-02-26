using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Basket.Dtos;
using ShopStar.Basket.LoginService;
using ShopStar.Basket.Services;

namespace ShopStar.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBaskerService _baskerService;
        private readonly ILoginService _loginService;

        public BasketsController(IBaskerService baskerService, ILoginService loginService)
        {
            _baskerService = baskerService;
            _loginService = loginService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMyBasket()
        {
            var user = User.Claims;
            var values = await _baskerService.GetBasket(_loginService.GetUserId);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> SaveMyBasket(BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _loginService.GetUserId;
            await _baskerService.SaveBasket(basketTotalDto);
            return Ok("Basket Changes saved");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMyBasket()
        {
            await _baskerService.DeleteBasket(_loginService.GetUserId);
            return Ok("Basket Delete Successfully");
        }
    }
}
