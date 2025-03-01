using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ProductListViewComponents
{
    public class _FilterByPriceProductListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
