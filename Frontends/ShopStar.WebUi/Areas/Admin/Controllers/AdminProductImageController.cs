using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.ProductImageDtos;
using System.Text;

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
        [HttpGet]
        [Route("ProductImageDetail/{id}")]
        public async Task<IActionResult> ProductImageDetail(string id)
        {

            ViewBag.v1 = "Home";
            ViewBag.v2 = "ProdutcImage";
            ViewBag.v3 = "update";
            ViewBag.v0 = "ProductImage";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/ProductImages/GetByProductIdProductImage?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateProductImageDto>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        [Route("ProductImageDetail/{id}")]
        public async Task<IActionResult> ProductImageDetail(UpdateProductImageDto updateProductImageDto)
        {
            var client=_httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductImageDto);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7113/api/ProductImages", stringcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ProductListWithCategory", "AdminProduct", new {area="Admin"});
            }
            return View();
        }
    }
}
