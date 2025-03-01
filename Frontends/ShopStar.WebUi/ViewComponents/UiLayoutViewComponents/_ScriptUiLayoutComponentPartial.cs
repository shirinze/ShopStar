using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.UiLayoutViewComponents
{
    public class _ScriptUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
