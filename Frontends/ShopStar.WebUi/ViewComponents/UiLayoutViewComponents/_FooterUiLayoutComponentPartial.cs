using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.AboutDtos;

namespace ShopStar.WebUi.ViewComponents.UiLayoutViewComponents
{
    public class _FooterUiLayoutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FooterUiLayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(value);
            }
            return View();
           
        }
    }
}
