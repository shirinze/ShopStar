using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
