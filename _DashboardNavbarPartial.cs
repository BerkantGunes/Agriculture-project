using Microsoft.AspNetCore.Mvc;

namespace Agriculture.ViewComponents
{
    public class _DashboardNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
