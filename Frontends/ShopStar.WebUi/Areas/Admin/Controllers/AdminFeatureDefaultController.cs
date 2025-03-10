using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.FeatureDefaultDtos;
using System.Text;

namespace ShopStar.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminFeatureDefault")]
    public class AdminFeatureDefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminFeatureDefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {

            ViewBag.v1 = "Home";
            ViewBag.v2 = "FeatureDefault";
            ViewBag.v3 = "List";
            ViewBag.v0 = "featuredefault list";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/FeatureDefaults");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultFeatureDefaultDto>>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpGet]
        [Route("CreateFeatureDefault")]
        public async Task<IActionResult> CreateFeatureDefault()
        {
            ViewBag.v1 = "Home";
            ViewBag.v2 = "FeatureDefault";
            ViewBag.v3 = "Add";
            ViewBag.v0 = "featuredefault ";
            return View();
        }
        [HttpPost]
        [Route("CreateFeatureDefault")]
        public async Task<IActionResult> CreateFeatureDefault(CreateFeatureDefaultDto createFeatureDefaultDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createFeatureDefaultDto);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7113/api/FeatureDefaults", stringcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFeatureDefault", new { area = "Admin" });
            }
            return View();
        }
        [Route("DeleteFeatureDefault/{id}")]
        public async Task<IActionResult> DeleteFeatureDefault(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7113/api/FeatureDefaults/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFeatureDefault", new { area = "Admin" });
            }
            return View();
        }
        [HttpGet]
        [Route("UpdateFeatureDefault/{id}")]
        public async Task<IActionResult> UpdateFeatureDefault(string id)
        {
            ViewBag.v1 = "Home";
            ViewBag.v2 = "FeatureSlider";
            ViewBag.v3 = "Update";
            ViewBag.v0 = "featuredefault";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/FeatureDefaults/" +id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateFeatureDefaultDto>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateFeatureDefault/{id}")]
        public async Task<IActionResult> UpdateFeatureDefault(UpdateFeatureDefaultDto updateFeatureDefaultDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFeatureDefaultDto);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7113/api/FeatureDefaults", stringcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFeatureDefault", new { area = "Admin" });
            }
            return View();
        }
    }
}
