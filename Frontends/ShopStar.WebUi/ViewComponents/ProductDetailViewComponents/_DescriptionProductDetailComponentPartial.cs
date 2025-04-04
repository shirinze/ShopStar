using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopStar.DtosLayer.Dtos.CatalogDtos.ProductDetailDtos;

namespace ShopStar.WebUi.ViewComponents.ProductDetailViewComponents
{
    
    public class _DescriptionProductDetailComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DescriptionProductDetailComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/ProductDetails/GetByProductIdProductDetail?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateProductDetailDto>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
