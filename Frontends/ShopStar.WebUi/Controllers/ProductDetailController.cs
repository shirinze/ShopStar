using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.x = id;
            return View();
        }
    }
}
