using Microsoft.AspNetCore.Mvc;
using ShopStar.WebUi.Services;

namespace ShopStar.WebUi.Controllers
{
    public class DefaultController : Controller
    {
        


        public IActionResult Index()
        {
            
            
            return View();
        }
    }
}
