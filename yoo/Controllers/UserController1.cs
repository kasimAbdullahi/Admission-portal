﻿using Microsoft.AspNetCore.Mvc;

namespace yoo.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
