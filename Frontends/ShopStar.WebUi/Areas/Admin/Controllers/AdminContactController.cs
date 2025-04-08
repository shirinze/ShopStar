using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.ContactDtos;
using System.Text;

namespace ShopStar.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminContact")]
    [AllowAnonymous]
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {

            ViewBag.v1 = "Home";
            ViewBag.v2 = "Contact";
            ViewBag.v3 = "List";
            ViewBag.v0 = "Contact list";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Contacts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(value);
            }
            return View();
        }

    }
}
