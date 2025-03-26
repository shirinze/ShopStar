using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Catalog.Dtos.AboutDtos;
using ShopStar.Catalog.Services.AboutServices;

namespace ShopStar.Catalog.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAboutList()
        {
            var value = await _aboutService.GetAllAboutAsync();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            await _aboutService.CreateAboutAsync(createAboutDto);
            return Ok("Create Success");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutById(string id)
        {
            var value = await _aboutService.GetByIdAboutAsync(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _aboutService.DeleteAboutAsync(id);
            return Ok("Delete Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutdto)
        {
            await _aboutService.UpdateAboutAsync(updateAboutdto);
            return Ok("Update Success");
        }
    }
}
