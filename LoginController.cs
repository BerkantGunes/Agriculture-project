using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
