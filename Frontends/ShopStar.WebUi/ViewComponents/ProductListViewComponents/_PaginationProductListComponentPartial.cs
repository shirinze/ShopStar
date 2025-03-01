using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ProductListViewComponents
{
    public class _PaginationProductListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
