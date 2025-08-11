using Microsoft.AspNetCore.Mvc;

namespace Agriculture.ViewComponents
{
    public class _DashboardChartPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 82;
            ViewBag.v2 = 96;
            return View();
        }
    }
}
