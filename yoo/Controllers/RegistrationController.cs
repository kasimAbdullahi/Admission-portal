using Microsoft.AspNetCore.Mvc;

namespace yoo.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult reg()
        {
            return View();
        }
    }
}
