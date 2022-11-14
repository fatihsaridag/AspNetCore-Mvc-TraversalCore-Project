﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
