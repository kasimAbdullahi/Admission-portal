using Microsoft.AspNetCore.Mvc;

namespace yoo.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult App()
        {
            return View();
        }
    }
}
