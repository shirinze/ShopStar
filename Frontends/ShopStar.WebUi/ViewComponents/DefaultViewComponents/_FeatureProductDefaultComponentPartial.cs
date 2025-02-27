using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.DefaultViewComponents
{
    public class _FeatureProductDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
