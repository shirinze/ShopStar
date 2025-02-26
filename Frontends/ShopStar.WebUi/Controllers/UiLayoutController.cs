using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class UiLayoutController : Controller
    {
        public IActionResult _UiLayout()
        {
            return View();
        }
    }
}
