using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
