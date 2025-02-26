using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.UiLayoutViewComponents
{
    public class _ScriptUiLayoutComponenPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
