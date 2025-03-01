using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ProductListViewComponents
{
    public class _ProductCountProductListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
