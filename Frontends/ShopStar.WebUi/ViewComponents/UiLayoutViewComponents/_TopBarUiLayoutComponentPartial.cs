using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.UiLayoutViewComponents
{
    public class _TopBarUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
