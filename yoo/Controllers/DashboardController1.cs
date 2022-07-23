using Microsoft.AspNetCore.Mvc;

namespace yoo.Controllers
{
    public class DashboardController1 : Controller
    {
        public IActionResult Dash()
        {
            return View();
        }
    }
}
