using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.ProductDtos;

namespace ShopStar.WebUi.ViewComponents.ProductDetailViewComponents
{
    public class _FeatureProductDetailComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FeatureProductDetailComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/Products/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
