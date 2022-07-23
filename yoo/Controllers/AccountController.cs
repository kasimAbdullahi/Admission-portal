using Microsoft.AspNetCore.Mvc;

namespace yoo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult sign()
        {
            return View();
        }
    }
}
