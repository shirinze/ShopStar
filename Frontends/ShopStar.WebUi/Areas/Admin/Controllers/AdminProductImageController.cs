using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.ProductImageDtos;

namespace ShopStar.WebUi.Areas.Admin.Controllers
{
    [Route("Admin/AdminProductImage")]
    [AllowAnonymous]
    [Area("Admin")]
    public class AdminProductImageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminProductImageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ProductImageDetail(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/ProductImages/GetByProductIdProductImage?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<GetByIdProductImageDto>(jsonData);
            }
            return View();
        }
    }
}
