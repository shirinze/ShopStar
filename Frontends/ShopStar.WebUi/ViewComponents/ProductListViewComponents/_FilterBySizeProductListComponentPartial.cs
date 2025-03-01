using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ProductListViewComponents
{
    public class _FilterBySizeProductListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
