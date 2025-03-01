using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ProductDetailViewComponents
{
    public class _FeatureProductDetailComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
