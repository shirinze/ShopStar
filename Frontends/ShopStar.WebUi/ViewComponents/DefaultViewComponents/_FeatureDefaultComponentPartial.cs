using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
