using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.DefaultViewComponents
{
    public class _RecentProductDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
