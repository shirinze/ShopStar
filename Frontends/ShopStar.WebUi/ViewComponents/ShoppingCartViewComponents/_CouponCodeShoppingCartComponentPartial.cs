using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.ViewComponents.ShoppingCartViewComponents
{
    public class _CouponCodeShoppingCartComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
