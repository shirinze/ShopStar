﻿using Microsoft.AspNetCore.Mvc;

namespace ShopStar.WebUi.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
