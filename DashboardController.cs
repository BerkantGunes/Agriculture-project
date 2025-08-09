using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
