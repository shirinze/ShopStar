using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.DefaultViewComponents
{
    public class _OfferDiscountComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
