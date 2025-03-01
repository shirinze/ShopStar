using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
