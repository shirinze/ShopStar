using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.UiLayoutViewComponents
{
    public class _NavBarUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
