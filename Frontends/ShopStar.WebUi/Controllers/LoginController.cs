using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
