using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ContactViewComponents
{
    public class _ContactFormContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
