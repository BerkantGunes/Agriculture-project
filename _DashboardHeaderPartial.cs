using Microsoft.AspNetCore.Mvc;

namespace Agriculture.ViewComponents
{
    public class _DashboardHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
