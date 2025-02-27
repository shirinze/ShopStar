using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.DefaultViewComponents
{
    public class _SpecialOfferDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
