using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Catalog.Dtos.FeatureDefaultDtos;
using ShopStar.Catalog.Dtos.FeatureSliderDtos;
using ShopStar.Catalog.Services.FeatureDefaultServices;
using ShopStar.Catalog.Services.FeatureSliderServices;

namespace ShopStar.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureDefaultsController : ControllerBase
    {
        private readonly IFeatureDefaultService _featureDefaultService;

        public FeatureDefaultsController(IFeatureDefaultService featureDefaultService)
        {
            _featureDefaultService = featureDefaultService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeatureDefaultList()
        {
            var values = await _featureDefaultService.GetAllFeatureDefaultAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeatureDefault(CreateFeatureDefaultDto createFeatureDefaultDto)
        {
            await _featureDefaultService.CreateFeatureDefaultAsync(createFeatureDefaultDto);
            return Ok("Create Success");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeatureDefault(string id)
        {
            await _featureDefaultService.DeleteFeatureDefaultAsync(id);
            return Ok("Delete Success");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFeatureDefault(UpdateFeatureDefaultDto updateFeatureDefaultDto)
        {
            await _featureDefaultService.UpdateFeatureDefaultAsync(updateFeatureDefaultDto);
            return Ok("Update Success");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureDefaultById(string id)
        {
            var value = await _featureDefaultService.GetByIdFeatureDefaultAsync(id);
            return Ok(value);
        }
    }
}
