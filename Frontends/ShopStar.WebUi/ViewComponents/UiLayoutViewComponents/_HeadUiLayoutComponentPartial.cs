using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.UiLayoutViewComponents
{
    public class _HeadUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        } 
    }
}
