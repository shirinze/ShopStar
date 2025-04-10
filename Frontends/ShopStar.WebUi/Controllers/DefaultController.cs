using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var user = User.Claims;
            int x;
            return View();
        }
    }
}
