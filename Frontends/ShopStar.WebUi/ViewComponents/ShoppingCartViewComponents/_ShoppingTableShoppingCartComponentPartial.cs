using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ShoppingCartViewComponents
{
    public class _ShoppingTableShoppingCartComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
