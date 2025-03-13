using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.FeatureDefaultDtos;

namespace ShopStar.WebUi.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FeatureDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/FeatureDefaults");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultFeatureDefaultDto>>(jsonData);
                return View(value);
            }
            return View();
            
        }
    }
}
